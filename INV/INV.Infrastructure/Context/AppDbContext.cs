
using INV.Domain.Entities.InventoryEntity.BasicEntity;
using Microsoft.EntityFrameworkCore;

namespace INV.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        #region Inventory Basic Data
            public DbSet<CategoryEntity> Categories { get; set; }
            public DbSet<SubCategoryEntity> SubCategories { get; set; }
            public DbSet<ProductEntity> Products { get; set; }
            public DbSet<UOMEntity> Units { get; set; }
        #endregion 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


            #region Inventory Basic Data
            modelBuilder.Entity<CategoryEntity>(entity =>
                {
                    entity.ToTable("Categories");
                    entity.HasKey(cat => cat.Id);
                    entity.HasIndex(cat => cat.CategoryName).IsUnique();
                });
                modelBuilder.Entity<SubCategoryEntity>(entity =>
                {
                    entity.ToTable("SubCategories");
                    entity.HasKey(subCat => subCat.Id);
                    entity.HasIndex(subCat => subCat.SubCategoryName).IsUnique();
                });
                modelBuilder.Entity<UOMEntity>(entity =>
                {
                    entity.ToTable("Units");
                    entity.HasKey(uom => uom.Id);
                    entity.HasIndex(uom => uom.UnitName).IsUnique();
                });
                modelBuilder.Entity<ProductEntity>(entity =>
                {
                    entity.ToTable("Products");
                    entity.HasKey(p => p.Id);
                    entity.HasIndex(p => p.ProductName).IsUnique();
                    entity.HasIndex(p => p.ProductCode).IsUnique();
                    entity.HasIndex(p => p.ProductShortName).IsUnique();
                });
            #endregion
    }

}
}
