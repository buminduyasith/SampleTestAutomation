using SampleTestAutomation.BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestAutomation.Utils;

namespace SampleTestAutomation.Pages
{


    namespace SampleTestAutomation.Pages
    {
        public class CommonMethods : BasePageSelenium
        {
            public void HandleAlert(bool accept = true)
            {
                var alert = Driver.SwitchTo().Alert();
                if (accept) alert.Accept();
                else alert.Dismiss();
            }

            public void NavigateTo(string url)
            {
                Driver.Navigate().GoToUrl(url);
                STALogger.Log($"Navigated to {url}");
            }
        }
    }
}
