using GoColis.Shipping.Infrastructure.Logistics.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoColis.Shipping.Infrastructure.Common;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<ContactEntity> Contacts { get; set; }

    public DbSet<PickupPointEntity> PickupPoints { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        modelBuilder.Entity<PickupPointEntity>()
                    .HasKey(p => p.Id);

        modelBuilder.Entity<ContactEntity>()
                   .HasKey(p => p.Id);

        //Database.EnsureCreated();

        base.OnModelCreating(modelBuilder);
    }
}