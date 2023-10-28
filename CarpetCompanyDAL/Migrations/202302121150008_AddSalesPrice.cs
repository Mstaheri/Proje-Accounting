namespace CarpetCompanyDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalesPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductRegistrations", "SalesPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductRegistrations", "SalesPrice");
        }
    }
}
