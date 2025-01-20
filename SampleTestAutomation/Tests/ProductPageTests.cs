using SampleTestAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Tests
{
    public class ProductPageTests : IClassFixture<ProductPage>
    {
        private readonly ProductPage _productPage;

        public ProductPageTests(ProductPage productPage)
        {
            _productPage = productPage;
        }

        [Fact]
        public void GetProductPrice_ShouldReturnPrice()
        {
            _productPage.Driver.Navigate().GoToUrl("https://www.demoblaze.com/prod.html?idp_=1");
            var price = _productPage.GetProductPrice();
            Assert.NotNull(price);
        }

        [Fact]
        public void AddToCart_ShouldAddProductToCart()
        {
            _productPage.Driver.Navigate().GoToUrl("https://www.demoblaze.com/prod.html?idp_=1");
            _productPage.AddProductToCart();
            Assert.Contains("Product added", _productPage.Driver.SwitchTo().Alert().Text);
        }
    }
}
