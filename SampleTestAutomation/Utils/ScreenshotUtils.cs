using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Utils
{
    public static class ScreenshotUtils
    {
        public static void CaptureScreenshot(IWebDriver driver, string testName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{testName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
            STALogger.Log($"Screenshot captured for test: {testName}");
        }
    }
}
