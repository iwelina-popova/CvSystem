namespace CvSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CvSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CvSystemDbContext context)
        {
            if (!context.CurriculumVitaes.Any())
            {
                DataSeeder.SeedInitialCv(context);
            }
        }
    }
}
