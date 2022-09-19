using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibb
{
    public class PreOrder:Order
    {
        private double preOrderDiscount = 0.9;

        public override double CalculatePrise()
        {
            Console.WriteLine("Calulating PreOrder price");
            double prise = 0;
            foreach (var product in products)
            {
                prise += product.Price;
            }

            return prise * preOrderDiscount;
        }
    }
}
