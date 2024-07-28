using Amazon.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Amazon.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Laptop",
                Price = 1000,
                Description = "High performance laptop with 16GB RAM and 512GB SSD.<br/> Ideal for gaming, programming, and design.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Electronics"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Smartphone",
                Price = 699.99,
                Description = "Latest smartphone with 5G connectivity and 128GB storage.<br/> Features a stunning display and excellent camera.",
                ImageUrl = "https://placehold.co/602x402",
                CategoryName = "Electronics"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Smartwatch",
                Price = 199.99,
                Description = "Smartwatch with heart rate monitor and GPS tracking.<br/> Perfect for fitness enthusiasts and tech lovers.",
                ImageUrl = "https://placehold.co/601x401",
                CategoryName = "Wearables"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Tablet",
                Price = 329.99,
                Description = "Versatile tablet with 10.5-inch display and 64GB storage.<br/> Great for entertainment and productivity on the go.",
                ImageUrl = "https://placehold.co/600x400",
                CategoryName = "Electronics"
            });

        }

    }
}
