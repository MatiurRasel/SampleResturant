using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Samosa",
                Price = 15,
                ProductDescription = "A fried South Asian pastry with a savoury filling, including ingredients such as spiced potatoes, onions, and peas.",
                ImageUrl = "https://drive.google.com/file/d/1YbDtCsClmwwYeDfzVLIyhH5jih9qnB5x/view?usp=share_link",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                ProductName = "Paneer Tikka",
                Price = 13.99,
                ProductDescription = "An Indian dish made from chunks of paneer marinated in spices and grilled in a tandoor.",
                ImageUrl = "https://drive.google.com/file/d/1euCZOZbWStvcQyueSOtx8oafD2c5mlVJ/view?usp=share_link",
                CategoryName = "Appetizer"
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                ProductName = "Sweet Pie",
                Price = 10.99,
                ProductDescription = "A pie is a baked dish which is usually made of a pastry dough casing that contains a filling of various sweet or savoury ingredients.",
                ImageUrl = "https://drive.google.com/file/d/1jylnF37jQKvXoe1rdm--dt-UjQJdEST7/view?usp=share_link",
                CategoryName = "Dessert"
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                ProductName = "Pav Bhaji",
                Price = 15,
                ProductDescription = "Pav Bhaji is a fast food dish from Mumbai (Bombay), India, consisting of a vegetable curry (bhaji) cooked in tomato gravy and served with a soft bread roll (pav).",
                ImageUrl = "https://drive.google.com/file/d/1aV-V_5KcMB7ankZjTezNX8ncbgYq4iie/view?usp=sharing",
                CategoryName = "Entree"
            });
        }
    }
}
