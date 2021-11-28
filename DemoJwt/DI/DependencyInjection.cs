using Infra.Data.Data;
using Infra.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoJwt.DI
{
    public static class DependencyInjection
    {
        public static void AddServicesExtention(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddDefaultIdentity<IdentityUserEntity>(opt => opt.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AppDbContext>();
        }
    }
}
