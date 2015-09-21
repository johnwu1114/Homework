using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class Discount
    {
        public int GetDiscount(List<Order> order)
        {
            var sameBookGroup = order.GroupBy(g => g.BookName);
            var serialGroup = sameBookGroup
                .Select((n, i) => new { 
                    Group = i / sameBookGroup.Count(), 
                    Value = n 
                })
                .GroupBy(g => g.Group)
                .Select(g => new
                {
                    Count = g.Sum(s => s.Value.Count()),
                    Sum = g.Sum(s => s.Value.Sum(o => o.Price))
                });

            return serialGroup.Sum(o => GetDiscount(o.Sum, o.Count));
        }

        private int GetDiscount(int sumPrice, int count)
        {
            switch (count)
            {
                case 2:
                    return Convert.ToInt32(sumPrice * 0.95);
                case 3:
                    return Convert.ToInt32(sumPrice * 0.90);
            }
            return sumPrice;
        }
    }
}