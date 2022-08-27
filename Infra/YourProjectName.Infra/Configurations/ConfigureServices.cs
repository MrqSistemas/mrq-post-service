using Microsoft.Extensions.DependencyInjection;
using YourProjectName.Application.Applications;
using YourProjectName.Business.Users;
using YourProjectName.Domain.Adapters;
using YourProjectName.Domain.Business;
using YourProjectName.Repository.Users;

namespace YourProjectName.Infra.Configurations
{
    public class ConfigureServices
    {
        public static void AddApplications(IServiceCollection services)
        {
            services.AddScoped<IUserApplication, UserApplication>();
        }

        public static void AddBusiness(IServiceCollection services)
        {
            services.AddScoped<IUserBusiness, UserBusiness>();
        }

        public static void AddAdapters(IServiceCollection services)
        {
            services.AddScoped<IUserAdapter, UserRepositorySqlServer>();
        }
    }
}
