using SuperMarketAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using SuperMarketAPI.Domain.Repositories;

namespace SuperMarketAPI.Infracstrure
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();
                entity.Property(x => x.Name).IsRequired().HasMaxLength(50);
                entity.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);

                modelBuilder.Entity<Product>(entity =>
                {
                    entity.HasKey(x => x.Id);
                    entity.Property(x => x.Id).ValueGeneratedOnAdd();
                });
            });
        }
    }
}
