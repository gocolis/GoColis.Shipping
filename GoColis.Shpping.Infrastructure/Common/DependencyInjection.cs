using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Domain.Logistics.Repository;
using GoColis.Shipping.Infrastructure.Logistics.Entities;
using GoColis.Shipping.Infrastructure.Logistics.Repository;
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
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlite(Path.Combine(Path.GetTempPath(),
                    configuration.GetRequiredSection("SqliteDbFile").Value)));

        services.AddTransient<IPickupPointRepository, PickupPointRepository>();
        // TODO: Add postgres database
        return services;
    }
}