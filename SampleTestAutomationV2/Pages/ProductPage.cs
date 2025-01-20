using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleTestAutomationV2.Base;

namespace SampleTestAutomationV2.Pages
{
    public class ProductPage : BasePage
    {
        public ProductPage() : base() { }

        // Locators
        private By AddToCartButton => By.XPath("//a[text()='Add to cart']");
        private By ProductTitle => By.XPath("//h2[@class='name']");

        // Methods
        public string GetProductTitle()
        {
            return Wait.Until(d => d.FindElement(ProductTitle)).Text;
        }

        public void ClickAddToCart()
        {
            Wait.Until(d => d.FindElement(AddToCartButton)).Click();
        }
    }
}
