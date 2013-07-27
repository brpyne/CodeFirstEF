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

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Toys.Add(new Toy() { Name = "Truck" });
            context.Toys.Add(new Toy() { Name = "Shovel" });

            base.Seed(context);
            context.SaveChanges();
        }
    }
}
