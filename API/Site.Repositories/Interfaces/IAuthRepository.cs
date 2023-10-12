using Site.Data.Entities;
using Site.Models;

namespace Site.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        UserModel ValidateUser(string Email, string Password);
        bool CreateUser(User user, string Role);
    }
}
