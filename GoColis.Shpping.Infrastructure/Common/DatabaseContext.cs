using FluentMigrator.Runner;
using GoColis.Shipping.Domain.Logistics.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoColis.Shipping.Infrastructure.Common;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options, IMigrationRunner runner) : base(options)
    {
        runner.ListMigrations();
        runner.MigrateUp();
    }

    public DbSet<ContactEntity> Contacts { get; set; }

    public DbSet<PickupPointEntity> PickupPoints { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PickupPointEntity>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<ContactEntity>()
                  .HasKey(p => p.Id);

        modelBuilder.Entity<PickupPointEntity>()
            .HasMany(x=> x.Contacts)
            .WithOne(x=>x.PickupPoint)
            .HasForeignKey(x=>x.PickupPointID)
                  ;


        base.OnModelCreating(modelBuilder);
    }
}