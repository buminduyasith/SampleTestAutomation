using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2
{
    public class ProductPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        // Locators
        private By AddToCartButton => By.XPath("//a[text()='Add to cart']");
        private By ProductTitle => By.XPath("//h2[@class='name']");

        // Methods
        public string GetProductTitle()
        {
            return _wait.Until(d => d.FindElement(ProductTitle)).Text;
        }

        public void ClickAddToCart()
        {
            _wait.Until(d => d.FindElement(AddToCartButton)).Click();
        }
    }
}
