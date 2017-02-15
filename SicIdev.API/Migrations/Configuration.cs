namespace SicIdev.API.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SicIdev.API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }


        protected override void Seed(SicIdev.API.Models.ApplicationDbContext context)
        {
        }
    }
}
