using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugin.DataStore.SQL2
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryID = 1, Name = "Milk", Description = "Milk" },
                    new Category { CategoryID = 2, Name = "Fish", Description = "Fish" },
                    new Category { CategoryID = 3, Name = "Meat", Description = "Meat" }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = 1, CategoryId = 1, Name = "Milk", Quantity = 100, Price = 3.99 },
                    new Product { ProductId = 2, CategoryId = 2, Name = "Fish", Quantity = 200, Price = 2.99 },
                    new Product { ProductId = 3, CategoryId = 3, Name = "Meat", Quantity = 300, Price = 5.99 }
                );
        }
    }
}
