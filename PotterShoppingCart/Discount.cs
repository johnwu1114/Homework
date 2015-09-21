﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class Discount
    {
        public int GetDiscount(List<Order> order)
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
            switch (count)
            {
                case 2:
                    return Convert.ToInt32(sumPrice * 0.95);

                case 3:
                    return Convert.ToInt32(sumPrice * 0.90);

                case 4:
                    return Convert.ToInt32(sumPrice * 0.80);

                case 5:
                    return Convert.ToInt32(sumPrice * 0.75);
            }
            return sumPrice;
        }
    }
}