using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2.Utils
{
    public static class BrowserUtilities
    {
        public static IWebDriver LaunchBrowser()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
           // chromeOptions.AddArguments("--headless"); // Runs Chrome in headless mode
            chromeOptions.AddArguments("--disable-gpu"); // Optional: Ensures compatibility in headless mode
            chromeOptions.AddArguments("--no-sandbox"); // Optional: Useful for CI/CD pipelines
            chromeOptions.AddArguments("--disable-dev-shm-usage"); // Optional: Resolves resource limits in containers
            return new ChromeDriver(chromeOptions);
        }

        public static void CloseBrowser(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
