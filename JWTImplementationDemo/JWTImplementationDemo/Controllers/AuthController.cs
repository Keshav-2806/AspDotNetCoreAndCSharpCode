using JWTImplementationDemo.Interfaces;
using JWTImplementationDemo.Models;
using JWTImplementationDemo.Request_Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTImplementationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        

        // POST api/<AuthController>
        [HttpPost]
        public string Post([FromBody] LoginRequest loginRequest )
        {
            var result = authService.LogIn(loginRequest);
            return result;
        }

        // POST api/<AuthController>/5
        [HttpPost("addUser")]
        public User  AddUser([FromBody] User value)
        {
            var user = authService.AddUser(value);
            return user;
        }

        
    }
}
