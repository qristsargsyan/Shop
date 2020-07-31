using Microsoft.EntityFrameworkCore;
using Shop.BLL.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(e=>
            {
                e.HasKey(p => p.Id);
                e.Property(p => p.Name).IsRequired();
            });
        }
    }
}
