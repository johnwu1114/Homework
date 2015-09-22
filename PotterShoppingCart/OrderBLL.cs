using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class OrderBLL
    {
        private static Dictionary<int, double> Discount;

        public OrderBLL()
        {
            if (Discount == null)
            {
                Discount = new Dictionary<int, double>();
                Discount.Add(2, 0.95);
                Discount.Add(3, 0.90);
                Discount.Add(4, 0.80);
                Discount.Add(5, 0.75);
            }
        }

        public int GetBills(Order model)
        {
            var bll = new ProductBLL();
            var products = bll.GetProductList();
            var orderProducts = new List<Product>();
            foreach (var item in model.Items)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    var product = bll.GetProduct(item.BookName);
                    if (product != null)
                        orderProducts.Add(product);
                }
            }

            return PreSum(orderProducts);
        }

        private int PreSum(List<Product> order)
        {
            //先將同類書籍分類
            var sameBookGroup = order
                .GroupBy(g => g.BookName);

            //把分類後的書籍加入索引值，再依索引值做為新的群組
            var bookList = sameBookGroup.Select(g => new
            {
                Value = g.Select((val, idx) => new
                {
                    Index = idx,
                    Value = val
                })
            }).SelectMany(g => g.Value.Select(v => new
            {
                Group = v.Index,
                Value = v.Value
            }));

            //把各群組計算總合
            var serialGroup = bookList
                .GroupBy(g => g.Group)
                .Select(g => new
                {
                    Count = g.Count(),
                    Sum = g.Sum(o => o.Value.Price)
                });

            return serialGroup.Sum(o => GetDiscount(o.Sum, o.Count));
        }

        private int GetDiscount(int sumPrice, int count)
        {
            if (Discount.ContainsKey(count))
            {
                return Convert.ToInt32(sumPrice * Discount[count]);
            }
            return sumPrice;
        }
    }
}