using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestAutomationV2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2.Pages
{
    public class HomePage : BasePage
    {
        public HomePage() : base() { }

        // Locators
        private By LoginLink => By.Id("login2");
        private By SignUpLink => By.Id("signin2");
        private By ProductLink(string productName) => By.XPath($"//a[text()='{productName}']");

        // Methods
        public void NavigateToHomePage(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void ClickLoginLink()
        {
            Wait.Until(d => d.FindElement(LoginLink)).Click();
        }

        public void ClickSignUpLink()
        {
            Wait.Until(d => d.FindElement(SignUpLink)).Click();
        }

        public void ClickProduct(string productName)
        {
            Wait.Until(d => d.FindElement(ProductLink(productName))).Click();
        }
    }
}
