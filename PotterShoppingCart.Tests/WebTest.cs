using FluentAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.Tests.PageObjects;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class WebTest : FluentTest
    {
        public WebTest()
        {
            SeleniumWebDriver.Bootstrap
                (SeleniumWebDriver.Browser.Chrome
                , SeleniumWebDriver.Browser.Firefox);
        }

        [TestMethod]
        public void WebTest_第一集買了一本_其他都沒買_return_100()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            int expected = 100;

            //act
            target.BuyBooks(order);

            //assert
            var result = new HomeIndexResultPage(this);
            result.TotalPriceShouldBe(expected);
        }

        [TestMethod]
        public void WebTest_第一集買了一本_第二集也買了一本_return_190()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            int expected = 190;

            //act
            target.BuyBooks(order);

            //assert
            var result = new HomeIndexResultPage(this);
            result.TotalPriceShouldBe(expected);
        }

        [TestMethod]
        public void WebTest_一二三集各買了一本_return_270()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 1 });
            int expected = 270;

            //act
            target.BuyBooks(order);

            //assert
            var result = new HomeIndexResultPage(this);
            result.TotalPriceShouldBe(expected);
        }

        [TestMethod]
        public void WebTest_一二三四集各買了一本_return_320()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第四集, Count = 1 });
            int expected = 320;

            //act
            target.BuyBooks(order);

            //assert
            var result = new HomeIndexResultPage(this);
            result.TotalPriceShouldBe(expected);
        }

        [TestMethod]
        public void WebTest_一二三四五集各買了一本_return_375()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第四集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第五集, Count = 1 });
            int expected = 375;

            //act
            target.BuyBooks(order);

            //assert
            var result = new HomeIndexResultPage(this);
            result.TotalPriceShouldBe(expected);
        }

        [TestMethod]
        public void WebTest_一二集各買了一本_第三集買了兩本_return_370()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 2 });
            int expected = 370;

            //act
            target.BuyBooks(order);

            //assert
            var result = new HomeIndexResultPage(this);
            result.TotalPriceShouldBe(expected);
        }

        [TestMethod]
        public void WebTest_第一集買了一本_第二三集各買了兩本_return_460()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();
            var order = new Order();
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第一集, Count = 1 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第二集, Count = 2 });
            order.Items.Add(new OrderItem() { BookName = BookName.哈利波特第三集, Count = 2 });
            int expected = 460;

            //act
            target.BuyBooks(order);

            //assert
            var result = new HomeIndexResultPage(this);
            result.TotalPriceShouldBe(expected);
        }
    }
}