using GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint;
using Microsoft.Extensions.DependencyInjection;

namespace GoColis.Shipping.Application;

public static class Services
{
    // TODO: Create Infrastructure specific configuration
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblyContaining(typeof(CreatePickupPointCommand));
        });

        // TODO: Add postgres database
        return services;
    }
}