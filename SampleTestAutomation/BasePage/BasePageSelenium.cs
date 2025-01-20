using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleTestAutomation.BasePage
{
    public abstract class BasePageSelenium : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public WebDriverWait Wait { get; private set; }

        public BasePageSelenium()
        {
            SetUp();
        }

        private void SetUp()
        {
            // Initialize Chrome WebDriver without specifying driver path
            var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("--headless"); // Runs Chrome in headless mode
            chromeOptions.AddArguments("--disable-gpu"); // Optional: Ensures compatibility in headless mode
            chromeOptions.AddArguments("--no-sandbox"); // Optional: Useful for CI/CD pipelines
            chromeOptions.AddArguments("--disable-dev-shm-usage"); // Optional: Resolves resource limits in containers

            // ChromeDriver will automatically use the correct driver executable from the NuGet package
            Driver = new ChromeDriver(chromeOptions);

            // Maximize the browser window
            Driver.Manage().Window.Maximize();

            // Set up a WebDriverWait with a timeout of 5 seconds
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }

        public void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            Driver?.Quit();
        }
    }
}
