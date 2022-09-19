using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibb
{
    public abstract class OrderDecorator:Order
    {
        protected Order order;

        public OrderDecorator(Order order)
        {
            this.order = order;
        }

        public abstract override double CalculatePrise();

    }
}
