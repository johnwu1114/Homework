using FluentAutomation;

namespace PotterShoppingCart.Tests.PageObjects
{
    public class HomeIndexPage : PageObject<HomeIndexPage>
    {
        public HomeIndexPage(FluentTest test)
            : base(test)
        {
            Url = "http://localhost:7506/";
        }

        internal void BuyFirstBook(int count)
        {
            string container = "#txt_0";
            I.Enter(count).In(container);
        }

        internal void BuySecondBook(int count)
        {
            string container = "#txt_1";
            I.Enter(count).In(container);
        }

        internal void BuyThirdBook(int count)
        {
            string container = "#txt_2";
            I.Enter(count).In(container);
        }

        internal void BuyFourthBook(int count)
        {
            string container = "#txt_3";
            I.Enter(count).In(container);
        }

        internal void BuyFifthBook(int count)
        {
            string container = "#txt_4";
            I.Enter(count).In(container);
        }

        internal void Submit()
        {
            string container = "input[type='submit']";
            I.Click(container);
        }
    }
}