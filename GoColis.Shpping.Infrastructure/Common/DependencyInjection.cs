using FluentMigrator.Runner;
using GoColis.Shipping.Application.Logistics.Interfaces;
using GoColis.Shipping.Domain.Logistics.Agregat;
using GoColis.Shipping.Infrastructure.Logistics.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GoColis.Shipping.Infrastructure.Common;

public static class DependencyInjection
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

            services.AddFluentMigratorCore()
           .ConfigureRunner(config =>
           {
               config.AddSQLite()
               .WithGlobalConnectionString(configuration.GetRequiredSection("SqliteDbFile").Value)
               .ScanIn(Assembly.GetExecutingAssembly()).For.All();

           })
           .AddLogging(config=>config.AddFluentMigratorConsole());
        }

        services.AddScoped<IPickupPointRepository<PickupPoint>, PickupPointRepository>();

        // TODO: Add postgres database
        return services;
    }
}