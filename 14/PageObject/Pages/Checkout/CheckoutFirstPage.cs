using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages.Checkout
{
    public class CheckoutFirstPage : BasePage
    {
        private string END_POINT = "checkout-step-one.html";

        // Описание элементов

        private readonly By _firstNameInputBy = By.Id("first-name");

        private readonly By _lastNameInputBy = By.Id("last-name");

        private readonly By _postalCodeInputBy = By.Id("postal-code");

        private readonly By _cancelButtonBy = By.Id("cancel");

        private readonly By _continueButtonBy = By.Id("continue");

        private readonly By _shoppingCartButtonBy = By.Id("shopping_cart_container");

        private readonly By _menuButtonBy = By.Id("react-burger-menu-btn");

        private readonly By _twitterButtonBy = By.LinkText("Twitter");

        private readonly By _facebookButtonBy = By.LinkText("Facebook");

        private readonly By _linkedInButtonBy = By.LinkText("LinkedIn");

        // Инициализация класса

        public CheckoutFirstPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public CheckoutFirstPage(IWebDriver driver) : base(driver, false)
        {
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return ContinueButton.Displayed;
            }

            catch (Exception e)
            {
                return false;
            }
        }

        // Методы

        public IWebElement FirstNameInput => Driver.FindElement(_firstNameInputBy);
        public IWebElement LastNameInput => Driver.FindElement(_lastNameInputBy);
        public IWebElement PostalCodeInput => Driver.FindElement(_postalCodeInputBy);
        public IWebElement CancelButton => Driver.FindElement(_cancelButtonBy);
        public IWebElement ContinueButton => Driver.FindElement(_continueButtonBy);
        public IWebElement ShoppingCartButton => Driver.FindElement(_shoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(_menuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(_twitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(_facebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(_linkedInButtonBy);
    }
}