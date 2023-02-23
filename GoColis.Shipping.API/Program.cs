using GoColis.Shipping.Api.EndPoints.PickupPoint;
using GoColis.Shpping.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructureServices(builder.Configuration, builder.Environment.IsDevelopment());

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPickupPointEndpoints();


app.Run();

