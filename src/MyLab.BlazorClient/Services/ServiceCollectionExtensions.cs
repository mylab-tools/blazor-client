using Microsoft.Extensions.DependencyInjection;
using MyLab.BlazorClient.Model;

namespace MyLab.BlazorClient.Services
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyLabApp(this IServiceCollection services, AppModel appModel)
        {
            return services.AddSingleton(appModel);
        }
    }
}
