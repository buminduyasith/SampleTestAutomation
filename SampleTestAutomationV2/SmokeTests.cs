using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomationV2
{
    public class SmokeTests : IDisposable
    {
        private readonly IWebDriver _driver;

        public SmokeTests()
        {
            _driver = BrowserUtilities.LaunchBrowser();
        }

        [Fact]
        public void Smoke_VerifyHomePageLoads()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            Assert.Equal("STORE", _driver.Title);
        }

        [Fact]
        public void Smoke_VerifyLoginModalOpens()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickLoginLink();
            WaitUtilities.WaitForElement(_driver, By.Id("logInModalLabel"));
            Assert.True(_driver.FindElement(By.Id("logInModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifySignUpModalOpens()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickSignUpLink();
            WaitUtilities.WaitForElement(_driver, By.Id("signInModalLabel"));
            Assert.True(_driver.FindElement(By.Id("signInModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyContactModalOpens()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            _driver.FindElement(By.XPath("//a[text()='Contact']")).Click();
            WaitUtilities.WaitForElement(_driver, By.Id("exampleModalLabel"));
            Assert.True(_driver.FindElement(By.Id("exampleModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyAboutUsVideoModalOpens()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            _driver.FindElement(By.XPath("//a[text()='About us']")).Click();
            WaitUtilities.WaitForElement(_driver, By.Id("videoModalLabel"));
            Assert.True(_driver.FindElement(By.Id("videoModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyCategoriesAreDisplayed()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(_driver, By.Id("cat"));
            Assert.True(_driver.FindElement(By.Id("cat")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyProductListIsDisplayed()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(_driver, By.Id("tbodyid"));
            Assert.True(_driver.FindElement(By.Id("tbodyid")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyProductDetailsPageLoads()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickProduct("Samsung galaxy s6");

            var productPage = new ProductPage(_driver);
            Assert.Equal("Samsung galaxy s6", productPage.GetProductTitle());
        }

        [Fact]
        public void Smoke_VerifyCartPageLoads()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            _driver.FindElement(By.Id("cartur")).Click();
            WaitUtilities.WaitForElement(_driver, By.XPath("//h2[text()='Products']"));
            Assert.True(_driver.FindElement(By.XPath("//h2[text()='Products']")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyFooterIsDisplayed()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(_driver, By.Id("footc"));
            Assert.True(_driver.FindElement(By.Id("footc")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyCarouselIsFunctional()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(_driver, By.Id("carouselExampleIndicators"));
            var carousel = _driver.FindElement(By.Id("carouselExampleIndicators"));
            Assert.True(carousel.Displayed);
        }

        [Fact]
        public void Smoke_VerifyUserCanNavigateToNextProductPage()
        {
            var homePage = new HomePage(_driver);
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            _driver.FindElement(By.Id("next2")).Click();
            WaitUtilities.WaitForElement(_driver, By.Id("tbodyid"));
            Assert.True(_driver.FindElement(By.Id("tbodyid")).Displayed);
        }

        public void Dispose()
        {
            BrowserUtilities.CloseBrowser(_driver);
        }
    }
}
