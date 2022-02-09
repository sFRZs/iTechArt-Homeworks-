using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;
using PageObject.Pages.Checkout;
using PageObject.Services;

namespace PageObject.Steps
{
    public class ConfirmOrderStep : BaseStep
    {
        public ConfirmOrderStep(IWebDriver driver) : base(driver)
        {
        }

        public void Confirm()
        {
            var cartPage = new ShoppingCartPage(Driver, true, true);
            cartPage.CheckoutButton.Click();

            var checkoutFirst = new CheckoutFirstPage(Driver, false);

            checkoutFirst.FirstNameInput.Clear();
            checkoutFirst.FirstNameInput.SendKeys(UsersConfigurator.FirstName);

            checkoutFirst.LastNameInput.Clear();
            checkoutFirst.LastNameInput.SendKeys(UsersConfigurator.LastName);

            checkoutFirst.PostalCodeInput.Clear();
            checkoutFirst.PostalCodeInput.SendKeys(UsersConfigurator.PostalCode);

            checkoutFirst.ContinueButton.Click();

            var checkoutSecond = new CheckoutSecondPage(Driver, false);
            checkoutSecond.FinishButton.Click();
        }
    }
}