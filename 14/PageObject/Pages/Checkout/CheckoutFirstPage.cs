using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages.Checkout
{
    public class CheckoutFirstPage : BasePage
    {
        private static string END_POINT = "checkout-step-one.html";

        // Описание элементов

        private static readonly By FirstNameInputBy = By.Id("first-name");

        private static readonly By LastNameInputBy = By.Id("last-name");

        private static readonly By PostalCodeInputBy = By.Id("postal-code");

        private static readonly By CancelButtonBy = By.Id("cancel");

        private static readonly By ContinueButtonBy = By.Id("continue");

        private static readonly By ShoppingCartButtonBy = By.Id("shopping_cart_container");

        private static readonly By MenuButtonBy = By.Id("react-burger-menu-btn");

        private static readonly By TwitterButtonBy = By.LinkText("Twitter");

        private static readonly By FacebookButtonBy = By.LinkText("Facebook");

        private static readonly By LinkedInButtonBy = By.LinkText("LinkedIn");

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

        public IWebElement FirstNameInput => Driver.FindElement(FirstNameInputBy);
        public IWebElement LastNameInput => Driver.FindElement(LastNameInputBy);
        public IWebElement PostalCodeInput => Driver.FindElement(PostalCodeInputBy);
        public IWebElement CancelButton => Driver.FindElement(CancelButtonBy);
        public IWebElement ContinueButton => Driver.FindElement(ContinueButtonBy);
        public IWebElement ShoppingCartButton => Driver.FindElement(ShoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(MenuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(TwitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(FacebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(LinkedInButtonBy);
    }
}