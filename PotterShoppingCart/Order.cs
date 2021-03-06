﻿using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public List<OrderItem> Items { get; set; }

        public int TotalPrice { get; set; }
    }

    public class OrderItem
    {
        public int Count { get; set; }

        public BookName BookName { get; set; }
    }
}