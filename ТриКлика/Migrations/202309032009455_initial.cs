namespace ТриКлика.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Females",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        productName = c.String(nullable: false),
                        productDescription = c.String(),
                        productImageOne = c.String(nullable: false),
                        productImageTwo = c.String(),
                        productImageThree = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kids",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        productName = c.String(nullable: false),
                        productDescription = c.String(),
                        productImageOne = c.String(nullable: false),
                        productImageTwo = c.String(),
                        productImageThree = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Males",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        productName = c.String(nullable: false),
                        productDescription = c.String(),
                        productImageOne = c.String(nullable: false),
                        productImageTwo = c.String(),
                        productImageThree = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Males");
            DropTable("dbo.Kids");
            DropTable("dbo.Females");
        }
    }
}
