

using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Concrete
{
    public partial class BasketDbContext : DbContext
    {
        public BasketDbContext()
        {
        }

        public BasketDbContext(DbContextOptions<BasketDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
