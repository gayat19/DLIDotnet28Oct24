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
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //creatingteh primary key
            modelBuilder.Entity<Product>().HasKey(prod => prod.ProductNumber).HasName("PK_ProductNumber");

            //modelBuilder.Entity<Order>().Property(o => o.OrderId).HasColumnName("OrderNumber");
            modelBuilder.Entity<Order>().HasKey(o => o.OrderId).HasName("PK_OrderID");

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .HasConstraintName("FK_OrderCustomer");

            modelBuilder.Entity<Order>()
                  .Property(o => o.OrderStatus)
                  .HasColumnType("varchar")
                  .HasMaxLength(10);


            //seeding data
            modelBuilder.Entity<User>().HasData(
                            new User { Username = "ramu", Password = "1234" },
                            new User { Username = "somu", Password = "4321" });

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 101, Name = "Ramu", Email = "ramu@gmail.com", Phone = 9876543210, DateOfBirth = new DateTime(2000,10,19), Username = "ramu" });
            

            //modelBuilder.Entity<Order>().HasData(new Order { OrderId=1,OrderDate=DateTime.Now,CustomerId=101,TotalAmount=30,Customer=new Customer { Id = 101 } });
        }
    }
}
