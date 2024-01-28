namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discountPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Females", "discountPrice", c => c.String());
            AddColumn("dbo.Kids", "discountPrice", c => c.String());
            AddColumn("dbo.Males", "discountPrice", c => c.String());
            AlterColumn("dbo.Females", "productPrice", c => c.String(nullable: false));
            AlterColumn("dbo.Kids", "productPrice", c => c.String(nullable: false));
            AlterColumn("dbo.Males", "productPrice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Males", "productPrice", c => c.String());
            AlterColumn("dbo.Kids", "productPrice", c => c.String());
            AlterColumn("dbo.Females", "productPrice", c => c.String());
            DropColumn("dbo.Males", "discountPrice");
            DropColumn("dbo.Kids", "discountPrice");
            DropColumn("dbo.Females", "discountPrice");
        }
    }
}
