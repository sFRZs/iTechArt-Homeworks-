using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages
{
    public class ShoppingCartPage : BasePage
    {
        private static string END_POINT = "cart.html";
        private readonly bool _isItemsInCart;

        // Описание элементов

        private static readonly By CheckoutButtonBy = By.Id("checkout");

        private static readonly By ContinueShoppingButtonBy = By.Id("continue-shopping");

        private static readonly By ItemsListBy = By.ClassName("cart_item");

        private static readonly By ShoppingCartButtonBy = By.Id("shopping_cart_container");

        private static readonly By MenuButtonBy = By.Id("react-burger-menu-btn");

        private static readonly By TwitterButtonBy = By.LinkText("Twitter");

        private static readonly By FacebookButtonBy = By.LinkText("Facebook");

        private static readonly By LinkedInButtonBy = By.LinkText("LinkedIn");


        // Инициализация класса

        public ShoppingCartPage(IWebDriver driver, bool openPageByUrl, bool isItemsInCart) : base(driver, openPageByUrl)
        {
            this._isItemsInCart = isItemsInCart;
        }

        public ShoppingCartPage(IWebDriver driver, bool isItemsInCart) : base(driver, false)
        {
            this._isItemsInCart = isItemsInCart;
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return CheckoutButton.Displayed;
            }

            catch (Exception e)
            {
                return false;
            }
        }

        // Методы
        public IWebElement CheckoutButton => Driver.FindElement(CheckoutButtonBy);
        public IWebElement ContinueShoppingButton => Driver.FindElement(ContinueShoppingButtonBy);

        public List<IWebElement> ItemsList
        {
            get
            {
                if (_isItemsInCart)
                {
                    return new List<IWebElement>(Driver.FindElements(ItemsListBy));
                }
                else
                {
                    throw new Exception("The shopping cart is empty.");
                }
            }
        }

        public IWebElement ShoppingCartButton => Driver.FindElement(ShoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(MenuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(TwitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(FacebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(LinkedInButtonBy);
    }
}