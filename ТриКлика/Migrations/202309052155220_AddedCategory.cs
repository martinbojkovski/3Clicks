namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Females", "productCategory", c => c.String());
            AddColumn("dbo.Kids", "productCategory", c => c.String());
            AddColumn("dbo.Males", "productCategory", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Males", "productCategory");
            DropColumn("dbo.Kids", "productCategory");
            DropColumn("dbo.Females", "productCategory");
        }
    }
}
