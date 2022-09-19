using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibb
{
    public class VipOrderDecorator: OrderDecorator
    {
        public VipOrderDecorator(Order order) : base(order) { }

        public override double CalculatePrise()
        {
            Console.WriteLine("Calulating VipOrder price");
            return this.order.CalculatePrise() * 0.9;
        }

    }
}
