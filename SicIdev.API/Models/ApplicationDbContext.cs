using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SicIdev.API.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("SicIdev", throwIfV1Schema: false)
        {
        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Domaine> Domaines { get; set; }
        public DbSet<Natureao> Natureaos { get; set; }
        public DbSet<Origineao> Origineaos { get; set; }
        public DbSet<Pays> Payses { get; set; }
        public DbSet<PriseEnCharge> PriseEnCharges { get; set; }
        public DbSet<Selection> Selections { get; set; }
        public DbSet<Typeao> Typeaos { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}