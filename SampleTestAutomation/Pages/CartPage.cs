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

        public void NavigateToCart()
        {
            var cartLink = Driver.FindElement(By.Id("cartur"));
            cartLink.Click();
        }

        public bool IsProductInCart(string productName)
        {
            var productInCart = Driver.FindElement(By.XPath($"//td[contains(text(), '{productName}')]"));
            return productInCart != null;
        }
    }
}
