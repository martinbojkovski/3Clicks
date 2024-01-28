namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialPriceForgotten : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Females", "productPrice", c => c.String(nullable: false));
            AddColumn("dbo.Kids", "productPrice", c => c.String(nullable: false));
            AddColumn("dbo.Males", "productPrice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Males", "productPrice");
            DropColumn("dbo.Kids", "productPrice");
            DropColumn("dbo.Females", "productPrice");
        }
    }
}
