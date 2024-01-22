using CommercialWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CommercialWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Foods> Foods { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Information> Information { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Database=CommercialWeb;TrustServerCertificate=True;");
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, CategoryName = "Food" },
                new Categories { CategoryId = 2, CategoryName = "Book" },
                new Categories { CategoryId = 3, CategoryName = "Furniture" }
            );
            List<Foods> foods = new List<Foods>() 
            {
                new Foods{ Id = 11, ProductName = "Apple Pie", Price = 7.5d, InStock = true},
                new Foods{ Id = 12, ProductName = "Garlic", Price = 3.5d, InStock = true},
                new Foods{ Id = 13, ProductName = "Banana", Price = 5d, InStock = true},
                new Foods{ Id = 14, ProductName = "Carrot Cake", Price = 10.59d, InStock = false},
                new Foods{ Id = 15, ProductName = "Salmon", Price = 11.35d, InStock = false}
            };
            modelBuilder.Entity<Foods>().HasData(foods);
            List<Information> information = new List<Information>()
            {
                new Information{ FoodId = 11, ProductType = "Pie", Storage = "Under 7 degree", Usage = "Reheat", BestBefore = new DateTime(2024,05,10)},
                new Information{ FoodId = 12, ProductType = "Herb", Storage = "23 degree", Usage = "Directly", BestBefore = new DateTime(2024,02,18)},
                new Information{ FoodId = 13, ProductType = "Fruit", Storage = "23 degree", Usage = "Directly", BestBefore = new DateTime(2024,08,20)},
                new Information{ FoodId = 14, ProductType = "Cake", Storage = "Under 7 degree", Usage = "Directly", BestBefore = new DateTime(2024,01,30)},
                new Information{ FoodId = 15, ProductType = "Fish", Storage = "Under 5 degree", Usage = "Reheat and Cook", BestBefore = new DateTime(2024,07,14)}
            };
            modelBuilder.Entity<Information>().HasData(information);
        }
    }
}
