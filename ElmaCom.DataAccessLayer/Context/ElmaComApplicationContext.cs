using ElmaCom.DataAccessLayer.Configuration;
using ElmaCom.Entity.Entites;
using Microsoft.EntityFrameworkCore;

namespace ElmaCom.DataAccessLayer.Context
{
    public class ElmaComApplicationContext : DbContext
    {
        public DbSet<BaseCategory> BaseCategories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BaseCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ElmaComdb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
