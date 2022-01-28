using Domain.Models;
using Domain.Interfaces.GenericsInterfaces;
using Domain.Services.GenericsServices;
using Infra.Data.Data;
using Infra.Data.Repositories.GenericsRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Domain.Interfaces;
using Domain.Services;
using Infra.Data.Repositories;
using Microsoft.AspNetCore.Identity;

namespace DemoJwt.DI
{
    public static class DependencyInjection
    {
        public static void AddServicesExtention(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddIdentity<AccountModel, ApplicationRole>(opt =>
            {
                opt.SignIn.RequireConfirmedAccount = false;
                opt.Password.RequiredLength = 6;
                opt.User.RequireUniqueEmail = true;
                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 0, 15, 0);
            }).AddMongoDbStores<AccountModel, ApplicationRole, Guid>(
                configuration.GetConnectionString("DefaultConnection"),
                configuration.GetSection("DatabaseName-Application").Value
                ).AddDefaultTokenProviders();

            services.AddTransient<IMongoDbContext, MongoDbContext>();
            services.AddTransient(typeof(IAddRepository<>), typeof(AddRepository<>));
            services.AddTransient(typeof(IAddService<>), typeof(AddService<>));
            services.AddTransient<IAccountInfoService, AccountInfoService>();
            services.AddTransient<IAccountInfoRepository, AccountInfoRepository>();
            services.AddTransient(typeof(IListServices<>), typeof(ListService<>));
            services.AddTransient(typeof(IListRepository<>), typeof(ListRepository<>));
        }
    }
}
