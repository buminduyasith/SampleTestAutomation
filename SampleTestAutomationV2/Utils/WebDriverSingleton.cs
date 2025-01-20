using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2.Utils
{
    public sealed class WebDriverSingleton
    {
        private static IWebDriver _instance = null;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private WebDriverSingleton() { }

        public static IWebDriver Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            var chromeOptions = new ChromeOptions();
                            chromeOptions.AddArguments("--disable-gpu");
                            chromeOptions.AddArguments("--no-sandbox");
                            chromeOptions.AddArguments("--disable-dev-shm-usage");

                            //chromeOptions.AddArgument("--start-maximized");
                            chromeOptions.AddArguments("--headless"); // Runs Chrome in headless mode
                            chromeOptions.AddArguments("--disable-gpu"); // Optional: Ensures compatibility in headless mode
                            chromeOptions.AddArguments("--no-sandbox"); // Optional: Useful for CI/CD pipelines
                            chromeOptions.AddArguments("--disable-dev-shm-usage"); // Optional: Resolves resource limits in containers

                            _instance = new ChromeDriver(chromeOptions);
                            _instance.Manage().Window.Maximize();
                        }
                    }
                }
                return _instance;
            }
        }

        public static void Quit()
        {
            if (_instance != null)
            {
                _instance.Quit();
                _instance = null;
            }
        }
    }
}
