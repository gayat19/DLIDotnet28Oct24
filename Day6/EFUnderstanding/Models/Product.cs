using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnderstanding.Models
{
    public class Product : IComparable<Product>, IEquatable<Product>
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
       
        public string BasicImgae { get; set; }
        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
            BasicImgae = string.Empty;
        }

        //public Product(int id, string name, float price, int? quantity, string? description, string? basicImgae)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description??string.Empty;
        //    Price = price;
        //    Quantity = quantity??0;
        //    BasicImgae = basicImgae ?? string.Empty;
        //}
        public Product(int id, string name, float price) : this()
        {
            ProductNumber = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Id {ProductNumber} \tName: {Name} \tPrice {Price} \tQuantity {Quantity}";
        }

        public int CompareTo(Product? other)
        {
            var product = other ?? new Product() { Price = 0 };
            return this.Price.CompareTo(product.Price);
        }

        public bool Equals(Product? other)
        {
            var product = other ?? new Product() { Price = 0, Name = string.Empty };
            return this.Price.Equals(product.Price) && this.Name.Equals(product.Name);
        }

    }
}
