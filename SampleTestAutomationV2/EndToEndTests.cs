using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2
{
    public class EndToEndTests : IDisposable
    {
        private readonly IWebDriver _driver;

        public EndToEndTests()
        {
            _driver = BrowserUtilities.LaunchBrowser();
        }

        [Fact]
        public async void E2E_AddProductToCart()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickProduct("Samsung galaxy s6");

            var productPage = new ProductPage(_driver);
            Assert.Equal("Samsung galaxy s6", productPage.GetProductTitle());
            productPage.ClickAddToCart();

            await Task.Delay(3000);
            _driver.SwitchTo().Alert().Accept();

            var cartPage = new CartPage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/cart.html");

            await Task.Delay(3000);
            Assert.True(cartPage.IsProductInCart("Samsung galaxy s6"));
        }

        public void Dispose()
        {
            BrowserUtilities.CloseBrowser(_driver);
        }
    }
}
