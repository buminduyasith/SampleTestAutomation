using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleTestAutomationV2.Utils;

namespace SampleTestAutomationV2.Base
{
    public abstract class BasePage : IDisposable
    {
        public IWebDriver Driver;
        public WebDriverWait Wait;

        // Constructor to initialize the WebDriver
        public BasePage()
        {
            SetUp();
        }

        private void SetUp()
        {
            Driver = WebDriverSingleton.Instance; // Use the singleton instance
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
        }

        public void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            Driver?.Quit();
        }

        // Method to navigate to a URL
        public void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
    }
}
