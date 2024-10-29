using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasicsApp.Models
{
    public class Product : IComparable<Product>, IEquatable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        //or
        //public Nullable<int> Quantity { get; set; }
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
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Id {Id} \tName: {Name} \tPrice {Price} \tQuantity {Quantity}";
        }

        public int CompareTo(Product? other)
        {
            var product = other ?? new Product() { Price=0};
            return this.Price.CompareTo(product.Price);
        }

        public bool Equals(Product? other)
        {
            var product = other ?? new Product() { Price = 0, Name = string.Empty };
            return this.Price.Equals(product.Price) && this.Name.Equals(product.Name);
        }
        //public override bool Equals(object? obj)
        //{
        //    var product = (obj??new Product()) as Product;
        //    return this.Price.Equals(product.Price) && this.Name.Equals(product.Name);
        //}
    }
}
