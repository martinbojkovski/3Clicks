namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductModelFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "productGender", c => c.String());
            AlterColumn("dbo.Products", "productBrand", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "productBrand", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "productGender", c => c.String(nullable: false));
        }
    }
}
