using OpenQA.Selenium;
using SampleTestAutomationV2.Utils;
using SampleTestAutomationV2.Pages;

namespace SampleTestAutomationV2.Tests
{
    public class EndToEndTests
    {

        [Fact]
        public async void E2E_AddProductToCart()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickProduct("Samsung galaxy s6");

            var productPage = new ProductPage();
            Assert.Equal("Samsung galaxy s6", productPage.GetProductTitle());
            productPage.ClickAddToCart();

            await Task.Delay(3000);
            homePage.Driver.SwitchTo().Alert().Accept();

            var cartPage = new CartPage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/cart.html");

            await Task.Delay(3000);
            Assert.True(cartPage.IsProductInCart("Samsung galaxy s6"));
        }
    }
}
