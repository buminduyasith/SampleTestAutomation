using OpenQA.Selenium;
using SampleTestAutomation.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Pages
{
    public class ProductPage : BasePageSelenium
    {
        public ProductPage() : base() { }

        // Locators
        private By ProductName => By.CssSelector(".name");
        private By ProductPrice => By.CssSelector(".price-container");
        private By ProductDescription => By.CssSelector(".description");
        private By AddToCartButton => By.CssSelector(".btn-success"); // "Add to cart" button

        // Methods to interact with the product page
        public string GetProductName()
        {
            string productName = Driver.FindElement(ProductName).Text;
            return productName;
        }

        public string GetProductPrice()
        {
            string productPrice = Driver.FindElement(ProductPrice).Text;
            return productPrice;
        }

        public string GetProductDescription()
        {
            string productDescription = Driver.FindElement(ProductDescription).Text;
            return productDescription;
        }

        public void AddProductToCart()
        {
            Driver.FindElement(AddToCartButton).Click();
        }
    }
}
