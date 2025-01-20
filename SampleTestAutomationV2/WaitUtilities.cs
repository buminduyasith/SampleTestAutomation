using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2
{
    public static class WaitUtilities
    {
        public static void WaitForElement(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(d => d.FindElement(locator).Displayed);
        }
    }
}
