using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        // Locators
        private By LoginLink => By.Id("login2");
        private By SignUpLink => By.Id("signin2");
        private By ProductLink(string productName) => By.XPath($"//a[text()='{productName}']");

        // Methods
        public void NavigateToHomePage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickLoginLink()
        {
            _wait.Until(d => d.FindElement(LoginLink)).Click();
        }

        public void ClickSignUpLink()
        {
            _wait.Until(d => d.FindElement(SignUpLink)).Click();
        }

        public void ClickProduct(string productName)
        {
            _wait.Until(d => d.FindElement(ProductLink(productName))).Click();
        }
    }
}
