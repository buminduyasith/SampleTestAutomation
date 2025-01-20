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

        public string GetProductPrice()
        {
            var priceElement = Driver.FindElement(By.CssSelector("h3.price-container"));
            return priceElement.Text;
        }

        public void AddToCart()
        {
            var addToCartButton = Driver.FindElement(By.LinkText("Add to cart"));
            addToCartButton.Click();
        }
    }
}
