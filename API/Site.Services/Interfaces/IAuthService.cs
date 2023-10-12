using Site.Data.Entities;
using Site.Models;

namespace Site.Services.Interfaces
{
    public interface IAuthService
    {
        bool CreateUser(User user, string Role);
        UserModel ValidateUser(string Username, string Password);
    }
}
