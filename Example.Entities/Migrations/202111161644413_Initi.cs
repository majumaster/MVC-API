namespace Example.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Orders", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
