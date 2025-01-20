using OpenQA.Selenium;
using SampleTestAutomation.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Pages
{
    public class HomePage : BasePageSelenium
    {
        public HomePage() : base() { }

        public void NavigateToHomePage()
        {
            Driver.Navigate().GoToUrl("https://www.demoblaze.com/");
        }

        public void ClickProductCategory(string categoryName)
        {
            var categoryLink = Driver.FindElement(By.LinkText(categoryName));
            categoryLink.Click();
        }

        public void SelectProduct(string productName)
        {
            var productLink = Driver.FindElement(By.LinkText(productName));
            productLink.Click();
        }
    }
}
