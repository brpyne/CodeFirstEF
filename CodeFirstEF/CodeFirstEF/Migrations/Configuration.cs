namespace CodeFirstEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /*
     * This file contains the settings that Migrations will use for migrating SandboxContext. 
     * It also contains a seed method to pre-populate your database.
     */

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstEF.SandboxContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstEF.SandboxContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  AddOrUpdate() to avoid creating duplicate seed data.
            //  Specify primary key to do the update and keep a consistent record set.
            context.Toys.AddOrUpdate(new Toy() { ToyID = 1, Name = "Car", Color = "Red"});
            context.Toys.AddOrUpdate(new Toy() { ToyID = 2, Name = "Bucket", Color = "Blue" });

            context.SaveChanges();
        }
    }
}
