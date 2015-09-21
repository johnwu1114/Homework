using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    class Discount
    {
        public int GetDiscount(List<Order> order)
        {
            return order.Sum(o => o.Price);
        }
    }
}
