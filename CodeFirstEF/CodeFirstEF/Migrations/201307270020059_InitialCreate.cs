namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sandboxes",
                c => new
                    {
                        SandboxID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsFun = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SandboxID);
            
            CreateTable(
                "dbo.Toys",
                c => new
                    {
                        ToyID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sandbox_SandboxID = c.Int(),
                    })
                .PrimaryKey(t => t.ToyID)
                .ForeignKey("dbo.Sandboxes", t => t.Sandbox_SandboxID)
                .Index(t => t.Sandbox_SandboxID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Toys", new[] { "Sandbox_SandboxID" });
            DropForeignKey("dbo.Toys", "Sandbox_SandboxID", "dbo.Sandboxes");
            DropTable("dbo.Toys");
            DropTable("dbo.Sandboxes");
        }
    }
}
