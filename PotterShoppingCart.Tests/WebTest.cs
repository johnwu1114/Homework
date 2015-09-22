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

            //act
            target.BuyFirstBook(1);
            target.Submit();

            //assert
            var result = new HomeIndexResultPage(this);
            int expected = 100;
            result.FindResult(expected);
        }

        [TestMethod]
        public void WebTest_第一集買了一本_第二集也買了一本_return_190()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();

            //act
            target.BuyFirstBook(1);
            target.BuySecondBook(1);
            target.Submit();

            //assert
            var result = new HomeIndexResultPage(this);
            int expected = 190;
            result.FindResult(expected);
        }

        [TestMethod]
        public void WebTest_一二三集各買了一本_return_270()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();

            //act
            target.BuyFirstBook(1);
            target.BuySecondBook(1);
            target.BuyThirdBook(1);
            target.Submit();

            //assert
            var result = new HomeIndexResultPage(this);
            int expected = 270;
            result.FindResult(expected);
        }

        [TestMethod]
        public void WebTest_一二三四集各買了一本_return_320()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();

            //act
            target.BuyFirstBook(1);
            target.BuySecondBook(1);
            target.BuyThirdBook(1);
            target.BuyFourthBook(1);
            target.Submit();

            //assert
            var result = new HomeIndexResultPage(this);
            int expected = 320;
            result.FindResult(expected);
        }

        [TestMethod]
        public void WebTest_一二三四五集各買了一本_return_375()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();

            //act
            target.BuyFirstBook(1);
            target.BuySecondBook(1);
            target.BuyThirdBook(1);
            target.BuyFourthBook(1);
            target.BuyFifthBook(1);
            target.Submit();

            //assert
            var result = new HomeIndexResultPage(this);
            int expected = 375;
            result.FindResult(expected);
        }

        [TestMethod]
        public void WebTest_一二集各買了一本_第三集買了兩本_return_370()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();

            //act
            target.BuyFirstBook(1);
            target.BuySecondBook(1);
            target.BuyThirdBook(2);
            target.Submit();

            //assert
            var result = new HomeIndexResultPage(this);
            int expected = 370;
            result.FindResult(expected);
        }

        [TestMethod]
        public void WebTest_第一集買了一本_第二三集各買了兩本_return_460()
        {
            //arrange
            var target = new HomeIndexPage(this);
            target.Go();

            //act
            target.BuyFirstBook(1);
            target.BuySecondBook(2);
            target.BuyThirdBook(2);
            target.Submit();

            //assert
            var result = new HomeIndexResultPage(this);
            int expected = 460;
            result.FindResult(expected);
        }
    }
}