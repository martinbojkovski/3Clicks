namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingShoppingCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        productQuantity = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ShoppingCartProducts",
                c => new
                    {
                        ShoppingCart_ID = c.Int(nullable: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCart_ID, t.Product_ID })
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCart_ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .Index(t => t.ShoppingCart_ID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCartProducts", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.ShoppingCartProducts", "ShoppingCart_ID", "dbo.ShoppingCarts");
            DropIndex("dbo.ShoppingCartProducts", new[] { "Product_ID" });
            DropIndex("dbo.ShoppingCartProducts", new[] { "ShoppingCart_ID" });
            DropTable("dbo.ShoppingCartProducts");
            DropTable("dbo.ShoppingCarts");
        }
    }
}
