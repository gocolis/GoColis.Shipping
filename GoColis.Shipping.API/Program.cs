using GoColis.Shipping.Api.Logistics;
using GoColis.Shipping.Application;
using GoColis.Shipping.Domain;
using GoColis.Shipping.Infrastructure.Common;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureServices(builder.Configuration, builder.Environment.IsDevelopment());

builder.Services.AddApplicationServices();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPickupPointEndpoints();

app.Run();