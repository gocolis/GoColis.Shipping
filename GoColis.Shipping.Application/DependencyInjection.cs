using FluentValidation;
using GoColis.Shipping.Application.Logistics.Commands.CreatePickupPoint;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using AutoMapper;

namespace GoColis.Shipping.Application;

public static class DependencyInjection
{
    // TODO: Create Infrastructure specific configuration
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });

        services.AddAutoMapper(cfg => { 
            cfg.AddMaps(typeof(DependencyInjection).Assembly);  
        });

        services.AddScoped<IValidator<CreatePickupPointCommand>, CreatePickupPointCommandValidator>();

        // TODO: Add postgres database
        return services;
    }
}