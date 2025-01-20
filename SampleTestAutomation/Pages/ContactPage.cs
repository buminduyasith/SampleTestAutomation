using OpenQA.Selenium;
using SampleTestAutomation.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Pages
{
    public class ContactPage : BasePageSelenium
    {
        public ContactPage() : base() { }
        private By ContactEmailField => By.Id("recipient-email");
        private By ContactNameField => By.Id("recipient-name");
        private By MessageField => By.Id("message-text");
        private By SubmitButton => By.CssSelector("button[type='submit']");

        // Methods to interact with the form
        public void EnterContactEmail(string email)
        {
            Driver.FindElement(ContactEmailField).SendKeys(email);
        }

        public void EnterContactName(string name)
        {
            Driver.FindElement(ContactNameField).SendKeys(name);
        }

        public void EnterMessage(string message)
        {
            Driver.FindElement(MessageField).SendKeys(message);
        }

        public void SubmitForm()
        {
            Driver.FindElement(SubmitButton).Click();
        }

        // Method to fill and submit the form
        public void FillAndSubmitForm(string email, string name, string message)
        {
            EnterContactEmail(email);
            EnterContactName(name);
            EnterMessage(message);
            SubmitForm();
        }
    }
}
