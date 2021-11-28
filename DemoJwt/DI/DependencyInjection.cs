using Domain.Entities;
using Domain.Interfaces.GenericsInterfaces;
using Domain.Services.GenericsServices;
using Infra.Data.Data;
using Infra.Data.Repositories.GenericsRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.DI
{
    public static class DependencyInjection
    {
        public static void AddDependenciesDbConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddDefaultIdentity<IdentityUserModel>(opt => opt.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AppDbContext>();
            services.AddTransient(typeof(IAddRepository<>), typeof(AddRepository<>));
            services.AddTransient(typeof(IAddService<>), typeof(AddService<>));
        }
    }
}
