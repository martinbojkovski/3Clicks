namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingProductModelFix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        productGender = c.String(nullable: false),
                        productBrand = c.String(nullable: false),
                        productName = c.String(nullable: false),
                        productPrice = c.String(nullable: false),
                        discountPrice = c.String(),
                        productCategory = c.String(),
                        productDescription = c.String(),
                        productImageOne = c.String(nullable: false),
                        productImageTwo = c.String(),
                        productImageThree = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
