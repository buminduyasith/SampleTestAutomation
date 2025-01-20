using SampleTestAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Tests
{
    public class CartPageTests : IClassFixture<CartPage>
    {
        private readonly CartPage _cartPage;

        public CartPageTests(CartPage cartPage)
        {
            _cartPage = cartPage;
        }

        [Fact]
        public void NavigateToCart_ShouldLoadCartPage()
        {
            _cartPage.NavigateToCart();
            Assert.Equal("https://www.demoblaze.com/cart.html", _cartPage.Driver.Url);
        }

        [Fact]
        public void IsProductInCart_ShouldReturnTrueIfProductExists()
        {
            _cartPage.NavigateToCart();
            Assert.True(_cartPage.IsProductInCart("Samsung galaxy s6"));
        }
    }
}
