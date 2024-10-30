using BackToBasicsApp.Exceptions;
using BackToBasicsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasicsApp.Repositories
{
    public class CustomerRepository : Repositories<int, Customer>
    {
        static IList<Customer> _customers = new List<Customer>();
        public CustomerRepository() :base(_customers)
        {
            
        }
        public override Customer Get(int key)
        {
            var customer = _customers.FirstOrDefault(c=>c.Id == key);
            if (customer == null)
                throw new EntityNotFoundException("Customer");
            return customer;
        }
    }
}
