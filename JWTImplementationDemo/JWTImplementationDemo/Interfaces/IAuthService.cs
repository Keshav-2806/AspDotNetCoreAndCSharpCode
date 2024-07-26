using JWTImplementationDemo.Models;
using JWTImplementationDemo.Request_Model;

namespace JWTImplementationDemo.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string LogIn(LoginRequest loginRequest);

    }
}
