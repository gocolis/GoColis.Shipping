using FluentMigrator;

namespace GoColis.Shipping.Infrastructure.Logistics.Migrations;

[Migration(20230227191000)]
public class Contact_20230227191000 : FluentMigrator.Migration
{
    const string tableName = "Contacts";
    const string index = "IX_CONTACT_PICKUPPOINT";
    public override void Down()
    {
        Delete.Index(index);
        Delete.Table(tableName);
    }

    public override void Up()
    {
        Create.Table(tableName)
            .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
            .WithColumn("firstName").AsString().NotNullable()
            .WithColumn("lastName").AsString().NotNullable()
            .WithColumn("email").AsString().NotNullable()
            .WithColumn("phone").AsString().NotNullable()
            .WithColumn("role").AsDecimal().Nullable()
            .WithColumn("PickupPointID").AsGuid().NotNullable().ForeignKey("PickupPoint_VS_Contact", "PickupPoints","id")
            .WithColumn("CreatedAt").AsDateTime().Nullable()
            .WithColumn("UpdatedAt").AsDateTime().Nullable()
            .WithColumn("CreatedBy").AsString().Nullable()
            .WithColumn("UpdatedBy").AsString().Nullable()
            ;

        Create.Index(index).OnTable(tableName).OnColumn("PickupPointID");
    }
}