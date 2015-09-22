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
            string container = string.Format("#txt_{0}", (int)BookName.哈利波特第一集);
            I.Enter(count).In(container);
        }

        internal void BuySecondBook(int count)
        {
            string container = string.Format("#txt_{0}", (int)BookName.哈利波特第二集);
            I.Enter(count).In(container);
        }

        internal void BuyThirdBook(int count)
        {
            string container = string.Format("#txt_{0}", (int)BookName.哈利波特第三集);
            I.Enter(count).In(container);
        }

        internal void BuyFourthBook(int count)
        {
            string container = string.Format("#txt_{0}", (int)BookName.哈利波特第四集);
            I.Enter(count).In(container);
        }

        internal void BuyFifthBook(int count)
        {
            string container = string.Format("#txt_{0}", (int)BookName.哈利波特第五集);
            I.Enter(count).In(container);
        }

        internal void Submit()
        {
            string container = "input[type='submit']";
            I.Click(container);
        }
    }
}