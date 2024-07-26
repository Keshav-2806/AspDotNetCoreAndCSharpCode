using JWTImplementationDemo.Context;
using JWTImplementationDemo.Interfaces;
using JWTImplementationDemo.Models;
using JWTImplementationDemo.Request_Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTImplementationDemo.Services
{
    public class AuthService : IAuthService
    {
        private readonly JWTContext jwtContext;
        private readonly IConfiguration configuration;

        public AuthService(JWTContext jwtContext, IConfiguration configuration)
        {
            this.jwtContext = jwtContext;
            this.configuration = configuration;
        }
        public User AddUser(User user)
        {
            var addedUser = jwtContext.Users.Add(user);
            jwtContext.SaveChanges();
            return addedUser.Entity;

        }

        public string LogIn(LoginRequest loginRequest)
        {
            if (loginRequest.Username != null && loginRequest.Password != null)
            {
                var user = jwtContext.Users.SingleOrDefault(s => s.Email == loginRequest.Username && s.Password == loginRequest.Password);
                if (user != null)
                {
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub,configuration["Jwt:Subject"]),
                        new Claim("Id",user.Id.ToString()),
                        new Claim("UserName",user.Name),
                        new Claim("Email",user.Email)
                    };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        configuration["Jwt:Issuer"],
                        configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn
                        );
                    var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return jwtToken;
                }
                else
                {
                    throw new Exception("User is not valid..");
                }

            }

            else
            {
                throw new Exception("Credentials are not valid..");
             }
        }
    }
}