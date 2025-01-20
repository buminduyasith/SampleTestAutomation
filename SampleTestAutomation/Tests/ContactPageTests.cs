using SampleTestAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestAutomation.Tests
{
    public class ContactPageTests : IClassFixture<ContactPage>
    {
        private readonly ContactPage _contactPage;

        public ContactPageTests(ContactPage contactPage)
        {
            _contactPage = contactPage;
        }

        [Fact]
        public void FillContactForm_ShouldSubmitSuccessfully()
        {
            // Arrange
            string email = "test@example.com";
            string name = "John Doe";
            string message = "This is a test message.";

            // Act
            _contactPage.NavigateTo("https://www.demoblaze.com/contact.html"); // Replace with the actual URL
            _contactPage.FillAndSubmitForm(email, name, message);

            // Assert
            // Assuming the form submission redirects or shows a success message
            // You can add assertions here to verify the form submission
            Assert.Contains("Thanks for the message!!", _contactPage.Driver.PageSource); // Example assertion
        }

        [Fact]
        public void SubmitEmptyForm_ShouldShowValidationErrors()
        {
            // Arrange
            _contactPage.NavigateTo("https://www.demoblaze.com/contact.html"); // Replace with the actual URL

            // Act
            _contactPage.SubmitForm();

            // Assert
            // Assuming the form shows validation errors for empty fields
            Assert.Contains("Please fill out this field", _contactPage.Driver.PageSource); // Example assertion
        }
    }
}