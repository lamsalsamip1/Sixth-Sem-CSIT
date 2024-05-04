using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;


namespace ProductAPI.Data
{
    public class ProductAPIContext : DbContext
    {
        public ProductAPIContext (DbContextOptions<ProductAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProductAPI.Models.Category> Category { get; set; } = default!;
        public DbSet<ProductAPI.Models.Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Student and Faculty
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.category_id);
        }
    }

    
}
