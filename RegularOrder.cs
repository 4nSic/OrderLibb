using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibb
{
    public class RegularOrder: Order
    {
        public override double CalculatePrise()
        {
            Console.WriteLine("Calulating RegularOrder price");
            double prise = 0;
            foreach (var product in products)
            {
                prise += product.Price;
            }

            return prise;
        }
    }
}
