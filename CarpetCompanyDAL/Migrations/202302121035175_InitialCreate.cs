namespace CarpetCompanyDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductRegistrations",
                c => new
                    {
                        ProductCode = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(),
                        Unit = c.String(),
                        PurchasePrice = c.Int(nullable: false),
                        BarCode = c.String(),
                    })
                .PrimaryKey(t => t.ProductCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductRegistrations");
        }
    }
}
