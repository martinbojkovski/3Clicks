namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class priceFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Females", "productPrice", c => c.String());
            AlterColumn("dbo.Kids", "productPrice", c => c.String());
            AlterColumn("dbo.Males", "productPrice", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Males", "productPrice", c => c.String(nullable: false));
            AlterColumn("dbo.Kids", "productPrice", c => c.String(nullable: false));
            AlterColumn("dbo.Females", "productPrice", c => c.String(nullable: false));
        }
    }
}
