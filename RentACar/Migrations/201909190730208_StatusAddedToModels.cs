namespace RentACar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusAddedToModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarModels", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Manufacturers", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Status");
            DropColumn("dbo.Orders", "Status");
            DropColumn("dbo.Cars", "Status");
            DropColumn("dbo.Manufacturers", "Status");
            DropColumn("dbo.CarModels", "Status");
        }
    }
}
