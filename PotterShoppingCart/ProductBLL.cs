using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ProductBLL
    {
        public Product GetProduct(BookName bookName)
        {
            return GetProductList().FirstOrDefault(p => p.BookName == bookName);
        }

        public List<Product> GetProductList()
        {
            var products = new List<Product>();
            products.Add(new Product() { BookName = BookName.哈利波特第一集, Price = 100 });
            products.Add(new Product() { BookName = BookName.哈利波特第二集, Price = 100 });
            products.Add(new Product() { BookName = BookName.哈利波特第三集, Price = 100 });
            products.Add(new Product() { BookName = BookName.哈利波特第四集, Price = 100 });
            products.Add(new Product() { BookName = BookName.哈利波特第五集, Price = 100 });
            return products;
        }
    }
}