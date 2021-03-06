﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class OrderBLLTest
    {
        [TestMethod]
        public void 第一集買了一本_其他都沒買_return_100()
        {
            //arrange
            var target = new OrderBLL();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            int expected = 100;

            //act
            int actual;
            actual = target.GetBills(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_return_190()
        {
            //arrange
            var target = new OrderBLL();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            int expected = 190;

            //act
            int actual;
            actual = target.GetBills(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本_return_270()
        {
            //arrange
            var target = new OrderBLL();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 1 });
            int expected = 270;

            //act
            int actual;
            actual = target.GetBills(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四集各買了一本_return_320()
        {
            //arrange
            var target = new OrderBLL();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第四集, Count = 1 });
            int expected = 320;

            //act
            int actual;
            actual = target.GetBills(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四五集各買了一本_return_375()
        {
            //arrange
            var target = new OrderBLL();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第四集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第五集, Count = 1 });
            int expected = 375;

            //act
            int actual;
            actual = target.GetBills(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二集各買了一本_第三集買了兩本_return_370()
        {
            //arrange
            var target = new OrderBLL();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 2 });
            int expected = 370;

            //act
            int actual;
            actual = target.GetBills(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本_第二三集各買了兩本_return_460()
        {
            //arrange
            var target = new OrderBLL();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 2 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 2 });
            int expected = 460;

            //act
            int actual;
            actual = target.GetBills(order);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}