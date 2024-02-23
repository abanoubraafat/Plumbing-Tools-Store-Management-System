namespace Plumbing_Tools_Store_Management_System_Main.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Plumbing_Tools_Store_Management_System_Main.Model.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Plumbing_Tools_Store_Management_System_Main.Model.DataContext";
        }

        protected override void Seed(Plumbing_Tools_Store_Management_System_Main.Model.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
