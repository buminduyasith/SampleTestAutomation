using SampleTestAutomation.BasePage;

namespace SampleTestAutomation
{
    public class UnitTest1 : BasePageSelenium
    {
        [Fact]
        public void OpenGoogleTest()
        {
            // Navigate to Google
            Driver.Navigate().GoToUrl("https://www.google.com");

            // Assert the title
            Assert.Contains("bumi", Driver.Title);
        }
    }
}