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
    }
}
