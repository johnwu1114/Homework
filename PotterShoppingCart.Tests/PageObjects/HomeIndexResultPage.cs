using FluentAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests.PageObjects
{
    public class HomeIndexResultPage : PageObject<HomeIndexResultPage>
    {
        private const string priceContainer = "#TotalPrice";

        public HomeIndexResultPage(FluentTest test)
            : base(test)
        {

        }

        internal void FindResult(int expectedPrice)
        {
            I.Assert.Text(expectedPrice.ToString()).In(priceContainer);
        }
    }
}
