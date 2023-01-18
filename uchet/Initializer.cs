using AutoSchool.DAL.Interfaces;
using AutoSchool.DAL.Repositories;
using AutoSchool.Domain.Entity;
using AutoSchool.Service.Implementations;
using AutoSchool.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace uchet
{
    public static class Initializer
    {

        
       public static void InitializeRepositories(this IServiceCollection services)
            {
                services.AddScoped<IBaseRepository<User>, UserRepository>();
            }
        

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
