using BackToBasicsApp.Exceptions;
using BackToBasicsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasicsApp.Repositories
{
    public class ProductRepository
    {
        Dictionary<int, Product> products = new Dictionary<int, Product>()
        {
            {101, new Product() { Id = 101, Name = "Pencil", Price = 5, Quantity = 10, BasicImgae = "" } },
            {102, new Product() { Id = 102, Name = "Eraser", Price = 3, Quantity = 7, BasicImgae = "" } },
            {103, new Product() { Id = 103, Name = "Pencil", Price = 5, Quantity = 10, BasicImgae = "" } }
        };
        /// <summary>
        /// Method to add a new product to the Dictionary
        /// </summary>
        /// <param name="product">A non nullable Product object that is populated</param>
        /// <returns></returns>
        /// <exception cref="ProductAlreadyExistsException"></exception>
        public Product Add(Product product) 
        {
            if (products.ContainsValue(product))
                throw new ProductAlreadyExistsException();
            products.Add(product.Id, product);
            return product;
        }
    }
}
