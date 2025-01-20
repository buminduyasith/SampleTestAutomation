using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestAutomation.BasePage;

namespace SampleTestAutomation
{
    public class UnitTest1 : BasePageSelenium
    {
        [Fact]
        public void OpenGoogleTest()
        {
            // Navigate to the URL
            Driver.Navigate().GoToUrl("https://www.demoblaze.com/");

            // Find and click on a product link (e.g., Samsung Galaxy S6)
            var productLink = Driver.FindElement(By.LinkText("Samsung galaxy s6"));
            productLink.Click();

            // Wait for the page to load (you might need to add explicit waits here)
            System.Threading.Thread.Sleep(2000);

            // Assert that the product page is loaded
            Assert.Contains("Samsung galaxy s6", Driver.PageSource);
        }
    }
}