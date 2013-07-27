namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColor : DbMigration
    {
        // Add-Migration AddColor
        // Update-Database

        public override void Up()
        {
            AddColumn("dbo.Toys", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Toys", "Color");
        }
    }
}
