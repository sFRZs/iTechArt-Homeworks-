using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages.Checkout
{
    public class CheckoutSecondPage : BasePage
    {
        private string END_POINT = "checkout-step-two.html";

        // Описание элементов

        private readonly By _cartItemsListBy = By.ClassName("cart_item");

        private readonly By _cancelButtonBy = By.Id("cancel");

        private readonly By _finishButtonBy = By.Id("finish");

        private readonly By _shoppingCartButtonBy = By.Id("shopping_cart_container");

        private readonly By _menuButtonBy = By.Id("react-burger-menu-btn");

        private readonly By _twitterButtonBy = By.LinkText("Twitter");

        private readonly By _facebookButtonBy = By.LinkText("Facebook");

        private readonly By _linkedInButtonBy = By.LinkText("LinkedIn");

        // Инициализация класса

        public CheckoutSecondPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public CheckoutSecondPage(IWebDriver driver) : base(driver, false)
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
                return FinishButton.Displayed;
            }

            catch (Exception e)
            {
                return false;
            }
        }

        // Методы

        public IWebElement CartItemsList => Driver.FindElement(_cartItemsListBy);
        public IWebElement CancelButton => Driver.FindElement(_cancelButtonBy);
        public IWebElement FinishButton => Driver.FindElement(_finishButtonBy);
        public IWebElement ShoppingCartButton => Driver.FindElement(_shoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(_menuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(_twitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(_facebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(_linkedInButtonBy);
    }
}