using SampleTestAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Tests
{
    public class HomePageTests : IClassFixture<HomePage>
    {
        private readonly HomePage _homePage;

        public HomePageTests(HomePage homePage)
        {
            _homePage = homePage;
        }

        [Fact]
        public void NavigateToHomePage_ShouldLoadSuccessfully()
        {
            _homePage.NavigateToHomePage();
            Assert.Equal("https://www.demoblaze.com/", _homePage.Driver.Url);
        }

        [Fact]
        public void Click_PhoneCategory_ShouldNavigateTo_PhotoCategoryPage()
        {
            _homePage.NavigateToHomePage();
            _homePage.ClickProductCategory("Phones");
            Assert.Contains("Phones", _homePage.Driver.PageSource);
        }

        [Fact]
        public void Click_LaptopCategory_ShouldNavigateTo_LaptopCategoryPage()
        {
            _homePage.NavigateToHomePage();
            _homePage.ClickProductCategory("Laptops");
            Assert.Contains("Laptops", _homePage.Driver.PageSource);
        }

        [Fact]
        public void Click_MonitorCategory_ShouldNavigateTo_MonitorCategoryPage()
        {
            _homePage.NavigateToHomePage();
            _homePage.ClickProductCategory("Monitors");
            Assert.Contains("Monitors", _homePage.Driver.PageSource);
        }
    }
}
