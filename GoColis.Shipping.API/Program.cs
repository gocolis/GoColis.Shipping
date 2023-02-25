using FluentValidation;
using GoColis.Shipping.Api.Logistics.UseCases.CreatePickupPoint;
using GoColis.Shipping.Domain.Logistics.UseCases.CreatePickupPoint;
using GoColis.Shipping.Infrastructure.Common;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureServices(builder.Configuration, builder.Environment.IsDevelopment());
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining(typeof(CreatePickupPoint));
});
builder.Services.AddScoped<IValidator<CreatePickupPointRequestViewModel>, CreatePickupPointRequestViewModelValidator>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPickupPointEndpoints();

app.Run();