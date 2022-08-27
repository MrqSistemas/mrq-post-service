using Microsoft.Extensions.DependencyInjection;
using PostService.Application.Applications;
using PostService.Business.Posts;
using PostService.Domain.Adapters;
using PostService.Domain.Business;
using PostService.Repository.Posts;

namespace PostService.Infra.Configurations
{
    public class ConfigureServices
    {
        public static void AddApplications(IServiceCollection services)
        {
            services.AddScoped<IPostApplication, PostApplication>();
        }

        public static void AddBusiness(IServiceCollection services)
        {
            services.AddScoped<IPostBusiness, PostBusiness>();
        }

        public static void AddAdapters(IServiceCollection services)
        {
            services.AddScoped<IPostAdapter, PostRepositorySqlServer>();
        }
    }
}
