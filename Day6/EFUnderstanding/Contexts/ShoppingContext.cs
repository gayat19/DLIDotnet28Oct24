using EFUnderstanding.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnderstanding.Contexts
{
    public class ShoppingContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KVHT2L3\SQLEXPRESS;Database=dbShopping;TrustServerCertificate=True;Integrated security=true");
        }
        public DbSet<Customer> Customers { get; set; } //By default this property name will be the table name
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //creatingteh primary key
            modelBuilder.Entity<Product>().HasKey(prod => prod.ProductNumber).HasName("PK_ProductNumber");


            //seeding data
            modelBuilder.Entity<User>().HasData(
                            new User { Username = "ramu", Password = "1234" },
                            new User { Username = "somu", Password = "4321" });

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 101, Name = "Ramu", Email = "ramu@gmail.com", Phone = 9876543210, DateOfBirth = new DateTime(2000,10,19), Username = "ramu" });
        }
    }
}
