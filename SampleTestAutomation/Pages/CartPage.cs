using OpenQA.Selenium;
using SampleTestAutomation.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Pages
{
    public class CartPage : BasePageSelenium
    {
        public CartPage() : base() { }

        // Locators
        private By CartItems => By.CssSelector(".success"); // Items in the cart
        private By ProductNameInCart => By.CssSelector(".success td:nth-child(2)"); // Product name in the cart

        // Methods to interact with the cart page
        public void NavigateToCart()
        {
            Driver.FindElement(By.XPath("//a[@onclick='addToCart(1)']")).Click();
        }

        public bool IsProductInCart(string productName)
        {
            try
            {
                var productInCart = Driver.FindElement(ProductNameInCart).Text;
                return productInCart.Contains(productName);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
