using BackToBasicsApp.Exceptions;
using BackToBasicsApp.Interfaces;
using BackToBasicsApp.Models;


namespace BackToBasicsApp.Repositories
{
    public class ProductRepository : IRepository<int, Product>
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

        public Product Delete(int key)
        {
            var product = Get(key);
            if (product != null)
            {
                products.Remove(key);
                return product;
            }
            throw new EntityNotFoundException("Product");
        }

        public Product Get(int key)
        {
            if (products.ContainsKey(key))
                return products[key];
            throw new EntityNotFoundException("Product");
        }

        public IEnumerable<Product> GetAll()
        {
            if (products.Count == 0)
                throw new CollectionEmptyException("Product");
            return products.Values;
        }

        public Product Update(int key, Product item)
        {
            var product = Get(key);
            if (product != null)
            {
                products[key] = item;
                return item;
            }
            throw new EntityNotFoundException("Product");
        }
    }
}
