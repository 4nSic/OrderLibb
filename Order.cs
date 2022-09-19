using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibb
{
    public abstract class Order
    {
        protected List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowProducts()
        {
            string message = "This order consists of:\n";

            foreach (var item in products)
            {
                message += item.Description + "\n";
            }

            Console.WriteLine(message);
        }

        public abstract double CalculatePrise();

    }
}
