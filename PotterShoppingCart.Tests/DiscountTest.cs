using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class DiscountTest
    {
        [TestMethod]
        public void 第一集買了一本_其他都沒買_return_100()
        {
            //arrange
            var terget = new Discount();
            var order = new List<Order>();
            order.Add(new Order() { BookName = BookName.哈利波特第一集, Price = 100 });
            int expected = 100;

            //act
            int actual;
            actual = terget.GetDiscount(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_return_190()
        {
            //arrange
            var terget = new Discount();
            var order = new List<Order>();
            order.Add(new Order() { BookName = BookName.哈利波特第一集, Price = 100 });
            order.Add(new Order() { BookName = BookName.哈利波特第二集, Price = 100 });
            int expected = 190;

            //act
            int actual;
            actual = terget.GetDiscount(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本_return_270()
        {
            //arrange
            var terget = new Discount();
            var order = new List<Order>();
            order.Add(new Order() { BookName = BookName.哈利波特第一集, Price = 100 });
            order.Add(new Order() { BookName = BookName.哈利波特第二集, Price = 100 });
            order.Add(new Order() { BookName = BookName.哈利波特第三集, Price = 100 });
            int expected = 270;

            //act
            int actual;
            actual = terget.GetDiscount(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四集各買了一本_return_320()
        {
            //arrange
            var terget = new Discount();
            var order = new List<Order>();
            order.Add(new Order() { BookName = BookName.哈利波特第一集, Price = 100 });
            order.Add(new Order() { BookName = BookName.哈利波特第二集, Price = 100 });
            order.Add(new Order() { BookName = BookName.哈利波特第三集, Price = 100 });
            order.Add(new Order() { BookName = BookName.哈利波特第四集, Price = 100 });
            int expected = 320;

            //act
            int actual;
            actual = terget.GetDiscount(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四五集各買了一本_return_375()
        {
            //arrange
            var terget = new Discount();
            var order = new List<Order>();
            int expected = 375;

            //act
            int actual;
            actual = terget.GetDiscount(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二集各買了一本_第三集買了兩本_return_370()
        {
            //arrange
            var terget = new Discount();
            var order = new List<Order>();
            int expected = 370;

            //act
            int actual;
            actual = terget.GetDiscount(order);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本_第二三集各買了兩本_return_420()
        {
            //arrange
            var terget = new Discount();
            var order = new List<Order>();
            int expected = 420;

            //act
            int actual;
            actual = terget.GetDiscount(order);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}