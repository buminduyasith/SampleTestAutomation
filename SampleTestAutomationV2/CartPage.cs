using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SampleTestAutomationV2
{
    public class CartPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        // Locators
        private By CartItem => By.XPath("//tbody[@id='tbodyid']/tr[1]/td[2]");
        private By PlaceOrderButton => By.XPath("//button[text()='Place Order']");

        // Methods
        public bool IsProductInCart(string productName)
        {
            return _wait.Until(d => d.FindElement(CartItem)).Displayed;
        }

        public void ClickPlaceOrder()
        {
            _wait.Until(d => d.FindElement(PlaceOrderButton)).Click();
        }
    }
}