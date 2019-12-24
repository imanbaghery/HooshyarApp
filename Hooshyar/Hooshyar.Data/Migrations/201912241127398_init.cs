namespace Hooshyar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CountTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                        CountType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountTypes", t => t.CountType_Id)
                .Index(t => t.CountType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "CountType_Id", "dbo.CountTypes");
            DropIndex("dbo.Items", new[] { "CountType_Id" });
            DropTable("dbo.Items");
            DropTable("dbo.CountTypes");
        }
    }
}
