using edTechSpark.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Site.Data;
using Site.Data.Entities;
using Site.Repositories.Implementations;
using Site.Repositories.Interfaces;
using Site.Services.Implementations;
using Site.Services.Interfaces;

namespace Site.Services.Configuration
{
    public static class ConfigureDependencies
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SiteDBContext>((options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SiteDB"));
            });

            services.AddScoped<DbContext, SiteDBContext>();

            services.AddScoped<IAuthRepository, AuthRepository>();

            services.AddScoped<IRepository<User>, Repository<User>>();

            //Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IService<User>, Service<User>>();
        }
    }
}
