using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Infrastructure.Logistics.Repositories;
using GoColis.Shipping.Infrastructure.Logistics.Repositories.Implement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoColis.Shipping.Infrastructure.Common;

public static class Services
{
    // TODO: Create Infrastructure specific configuration
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration, bool IsDevelopment)
    {
        if (IsDevelopment)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlite(configuration.GetRequiredSection("SqliteDbFile").Value)
                );
        }

        services.AddTransient<IPickupPointRepository<PickupPoint>, PickupPointRepository>();

        // TODO: Add postgres database
        return services;
    }
}