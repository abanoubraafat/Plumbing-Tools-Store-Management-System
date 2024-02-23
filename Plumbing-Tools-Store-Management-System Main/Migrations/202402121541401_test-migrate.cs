namespace Plumbing_Tools_Store_Management_System_Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmigrate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Image", c => c.Binary());
        }
    }
}
