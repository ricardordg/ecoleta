using Microsoft.Extensions.DependencyInjection;
using webapiserver.Data.Repositories;
using webapiserver.Domain.Interfaces;

namespace webapiserver.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPointsRepository, PointsRepository>();
            services.AddScoped<IItemsRepository, ItemsRepository>();
            services.AddScoped<IPointItemsRepository, PointItemsRepository>();
        }
    }
}
