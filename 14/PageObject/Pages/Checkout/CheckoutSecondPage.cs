using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages.Checkout
{
    public class CheckoutSecondPage : BasePage
    {
        private static string END_POINT = "checkout-step-two.html";

        // Описание элементов

        private static readonly By CartItemsListBy = By.ClassName("cart_item");

        private static readonly By CancelButtonBy = By.Id("cancel");

        private static readonly By FinishButtonBy = By.Id("finish");

        private static readonly By ShoppingCartButtonBy = By.Id("shopping_cart_container");

        private static readonly By MenuButtonBy = By.Id("react-burger-menu-btn");

        private static readonly By TwitterButtonBy = By.LinkText("Twitter");

        private static readonly By FacebookButtonBy = By.LinkText("Facebook");

        private static readonly By LinkedInButtonBy = By.LinkText("LinkedIn");

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

        public IWebElement CartItemsList => Driver.FindElement(CartItemsListBy);
        public IWebElement CancelButton => Driver.FindElement(CancelButtonBy);
        public IWebElement FinishButton => Driver.FindElement(FinishButtonBy);
        public IWebElement ShoppingCartButton => Driver.FindElement(ShoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(MenuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(TwitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(FacebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(LinkedInButtonBy);
    }
}