using Microsoft.EntityFrameworkCore;
using Site.Data;
using Site.Data.Entities;
using Site.Models;
using Site.Repositories.Interfaces;
using BC = BCrypt.Net.BCrypt;

namespace Site.Repositories.Implementations
{
    public class AuthRepository : Repository<User>, IAuthRepository
    {
        private SiteDBContext dbContext
        {
            get
            {
                return _dbContext as SiteDBContext;
            }
        }

        public AuthRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public bool CreateUser(User user, string Role)
        {
            try
            {
                user.Password = BC.HashPassword(user.Password);

                var role = dbContext.Roles.Where(r => r.Name == Role).FirstOrDefault();
                user.Roles.Add(role);
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public UserModel ValidateUser(string Email, string Password)
        {
            var user = dbContext.Users.Include(u => u.Roles).Where(u => u.Email == Email).FirstOrDefault();
            if (user != null)
            {
                var isVerified = BC.Verify(Password, user.Password);
                if (isVerified)
                {
                    UserModel model = new UserModel();

                    model.Id = user.Id;
                    model.Name = user.Name;
                    model.Email = user.Email;
                    model.PhoneNumber = user.PhoneNumber;
                    model.Roles = user.Roles.Select(r => r.Name).ToArray();
                    return model;
                }
            }
            return null;
        }
    }
}
