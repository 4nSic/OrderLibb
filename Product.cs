using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibb
{
    public class Product
    {
        public String Description { get; private set; }
        public double Price { get; private set; }

        public Product(string description, float price)
        {
            Description = description;
            Price = price;
        }
    }
}
