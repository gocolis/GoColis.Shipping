using FluentMigrator;

namespace GoColis.Shipping.Infrastructure.Logistics.Migrations;

[Migration(20230227190000)]
public class PickupPoint_20230227190000 : FluentMigrator.Migration
{
    const string tableName = "PickupPoints";
    public override void Down()
    {
        Delete.Table(tableName);
    }

    public override void Up()
    {
        Create.Table(tableName)
            .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
            .WithColumn("IdSte").AsGuid().NotNullable()
            .WithColumn("Adresse").AsString().NotNullable()
            .WithColumn("Latitude").AsDecimal().Nullable()
            .WithColumn("Longitude").AsDecimal().Nullable()
            .WithColumn("CreatedAt").AsDateTime().Nullable()
            .WithColumn("UpdatedAt").AsDateTime().Nullable()
            .WithColumn("CreatedBy").AsString().Nullable()
            .WithColumn("UpdatedBy").AsString().Nullable()
            ;
    }
}
