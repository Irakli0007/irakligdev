namespace irakligdev.ScoreContextMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ScoreConfiguration : DbMigrationsConfiguration<irakligdev.Models.ScoreContext>
    {
        public ScoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ScoreContextMigrations";
            ContextKey = "irakligdev.DBEntities.ScoreContext";
        }

        protected override void Seed(irakligdev.Models.ScoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
