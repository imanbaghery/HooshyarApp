namespace Hooshyar.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCount_toDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Count", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Count", c => c.Int(nullable: false));
        }
    }
}
