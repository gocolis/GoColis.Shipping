using GoColis.Shipping.Domain.Logistics.Agregat;
using Microsoft.EntityFrameworkCore;

namespace GoColis.Shipping.Infrastructure.Common;

public class DatabaseContext : DbContext
{
    public DbSet<PickupPoint> PickupPoints { get; set; }
    public DatabaseContext(DbContextOptions options) : base(options)
    {

    }
}