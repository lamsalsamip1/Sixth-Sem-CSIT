using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public class ProductsAPIContext : DbContext
    {
        public ProductsAPIContext (DbContextOptions<ProductsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsAPI.Models.category> category { get; set; } = default!;
        public DbSet<ProductsAPI.Models.product> product { get; set; } = default!;
    }
}
