namespace BakeryShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produkts",
                c => new
                    {
                        ProduktId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quanity = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ProduktId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produkts");
        }
    }
}
