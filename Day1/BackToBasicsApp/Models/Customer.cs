using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasicsApp.Models
{
    public class Customer : IEquatable<Customer>, IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Phone { get; set; }
        public string Email { get; set; } = string.Empty;

        public int CompareTo(Customer? other)
        {
            var customer = other ?? new Customer();
            return customer.Name.CompareTo(this.Name);
        }

        public bool Equals(Customer? other)
        {
            var customer = other ?? new Customer();
            return customer.Id.Equals(this.Id);
        }
        public override string ToString()
        {
            return $"Id {Id}\tName {Name}\tPhone {Phone}\tEmail {Email}";
        }
    }
}
