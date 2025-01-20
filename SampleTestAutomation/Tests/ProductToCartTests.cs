using SampleTestAutomation.BasePage;
using SampleTestAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Tests
{
    public class ProductToCartTests : IClassFixture<BasePageSelenium>
    {
        private readonly ProductPage _productPage;
        private readonly CartPage _cartPage;

        public ProductToCartTests(BasePageSelenium basePage)
        {
            _productPage = new ProductPage();
            _cartPage = new CartPage();
        }

        [Fact]
        public void E2E_AddProductToCart_ShouldAddProductSuccessfully()
        {
            // Arrange
            string productName = "Samsung galaxy s6"; // Expected product name
            string productUrl = "https://www.demoblaze.com/prod.html?idp_=1";

            // Act
            // Step 1: Navigate to the product page
            _productPage.NavigateTo(productUrl);

            // Step 2: Verify product details
            string actualProductName = _productPage.GetProductName();
            string productPrice = _productPage.GetProductPrice();
            string productDescription = _productPage.GetProductDescription();

            // Step 3: Add the product to the cart
            _productPage.AddProductToCart();

            // Step 4: Navigate to the cart page
            _cartPage.NavigateToCart();

            // Step 5: Verify the product is in the cart
            bool isProductInCart = _cartPage.IsProductInCart(productName);

            // Assert
            Assert.Equal(productName, actualProductName); // Verify product name
            Assert.Contains("$", productPrice); // Verify price contains a dollar sign
            Assert.NotEmpty(productDescription); // Verify description is not empty
            Assert.True(isProductInCart, $"Product '{productName}' is not in the cart."); // Verify product is in the cart
        }
    }
}
