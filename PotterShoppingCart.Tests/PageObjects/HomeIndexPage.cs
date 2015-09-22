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

        internal void BuyBooks(Order order)
        {
            string container = string.Empty;
            order.Items.ForEach(o =>
            {
                container = string.Format("#txt_{0}", (int)o.BookName);
                I.Enter(o.Count).In(container);
            });
            container = "input[type='submit']";
            I.Click(container);
        }
    }
}