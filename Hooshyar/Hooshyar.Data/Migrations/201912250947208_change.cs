namespace Hooshyar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Items", name: "CountType_Id", newName: "CountTypeId");
            RenameIndex(table: "dbo.Items", name: "IX_CountType_Id", newName: "IX_CountTypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Items", name: "IX_CountTypeId", newName: "IX_CountType_Id");
            RenameColumn(table: "dbo.Items", name: "CountTypeId", newName: "CountType_Id");
        }
    }
}
