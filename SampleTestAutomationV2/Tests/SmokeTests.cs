using OpenQA.Selenium;
using SampleTestAutomationV2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleTestAutomationV2.Pages;

namespace SampleTestAutomationV2.Tests
{
    public class SmokeTests
    {

        [Fact]
        public void Smoke_VerifyHomePageLoads()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            Assert.Equal("STORE", homePage.Driver.Title);
        }

        [Fact]
        public void Smoke_VerifyLoginModalOpens()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickLoginLink();
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("logInModalLabel"));
            Assert.True(homePage.Driver.FindElement(By.Id("logInModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifySignUpModalOpens()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickSignUpLink();
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("signInModalLabel"));
            Assert.True(homePage.Driver.FindElement(By.Id("signInModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyContactModalOpens()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.Driver.FindElement(By.XPath("//a[text()='Contact']")).Click();
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("exampleModalLabel"));
            Assert.True(homePage.Driver.FindElement(By.Id("exampleModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyAboutUsVideoModalOpens()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.Driver.FindElement(By.XPath("//a[text()='About us']")).Click();
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("videoModalLabel"));
            Assert.True(homePage.Driver.FindElement(By.Id("videoModalLabel")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyCategoriesAreDisplayed()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("cat"));
            Assert.True(homePage.Driver.FindElement(By.Id("cat")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyProductListIsDisplayed()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("tbodyid"));
            Assert.True(homePage.Driver.FindElement(By.Id("tbodyid")).Displayed);
        }

        [Fact]
        public async void Smoke_VerifyProductDetailsPageLoads()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.ClickProduct("Samsung galaxy s6");

            var productPage = new ProductPage();
            Assert.Equal("Samsung galaxy s6", productPage.GetProductTitle());
        }

        [Fact]
        public void Smoke_VerifyCartPageLoads()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.Driver.FindElement(By.Id("cartur")).Click();
            WaitUtilities.WaitForElement(homePage.Driver, By.XPath("//h2[text()='Products']"));
            Assert.True(homePage.Driver.FindElement(By.XPath("//h2[text()='Products']")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyFooterIsDisplayed()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("footc"));
            Assert.True(homePage.Driver.FindElement(By.Id("footc")).Displayed);
        }

        [Fact]
        public void Smoke_VerifyCarouselIsFunctional()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("carouselExampleIndicators"));
            var carousel = homePage.Driver.FindElement(By.Id("carouselExampleIndicators"));
            Assert.True(carousel.Displayed);
        }

        [Fact]
        public void Smoke_VerifyUserCanNavigateToNextProductPage()
        {
            var homePage = new HomePage();
            homePage.NavigateToHomePage("https://www.demoblaze.com/");
            homePage.Driver.FindElement(By.Id("next2")).Click();
            WaitUtilities.WaitForElement(homePage.Driver, By.Id("tbodyid"));
            Assert.True(homePage.Driver.FindElement(By.Id("tbodyid")).Displayed);
        }
    }
}
