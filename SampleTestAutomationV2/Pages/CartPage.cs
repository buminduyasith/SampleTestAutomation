using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SampleTestAutomationV2.Base;

namespace SampleTestAutomationV2.Pages
{
    public class CartPage : BasePage
    {
        public CartPage() : base() { }

        // Locators
        private By CartItem => By.XPath("//tbody[@id='tbodyid']/tr[1]/td[2]");
        private By PlaceOrderButton => By.XPath("//button[text()='Place Order']");

        // Methods
        public bool IsProductInCart(string productName)
        {
            return Wait.Until(d => d.FindElement(CartItem)).Displayed;
        }

        public void ClickPlaceOrder()
        {
            Wait.Until(d => d.FindElement(PlaceOrderButton)).Click();
        }
    }
}