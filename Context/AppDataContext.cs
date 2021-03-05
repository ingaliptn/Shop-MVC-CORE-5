using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Context
{
    public class AppDataContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(
                    prod =>
                    {
                        prod.Property(p => p.RetailPrice)
                            .HasColumnType("money");
                        prod.Property(p => p.WholesalePrice)
                            .HasColumnType("money");

                        prod.HasOne(p => p.Category)
                            .WithMany(c => c.Products)
                            .HasForeignKey(p => p.CategoryId);

                        prod.HasOne(p => p.Asset)
                            .WithMany(a => a.Products)
                            .HasForeignKey(p => p.AssetId);
                    });

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { Name = "Pivo Razliv", Id = Guid.NewGuid() },
                    new Category { Name = "Pivo Banki", Id = Guid.NewGuid() },
                    new Category { Name = "Pivo Bokal", Id = Guid.NewGuid() });

            base.OnModelCreating(modelBuilder);
        }
    }
}