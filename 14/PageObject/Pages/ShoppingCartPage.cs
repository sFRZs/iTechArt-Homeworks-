using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages
{
    public class ShoppingCartPage : BasePage
    {
        private string END_POINT = "cart.html";
        private readonly bool _isItemsInCart;

        // Описание элементов

        private readonly By _checkoutButtonBy = By.Id("checkout");

        private readonly By _continueShoppingButtonBy = By.Id("continue-shopping");

        private readonly By _itemsListBy = By.ClassName("cart_item");

        private readonly By _shoppingCartButtonBy = By.Id("shopping_cart_container");

        private readonly By _menuButtonBy = By.Id("react-burger-menu-btn");

        private readonly By _twitterButtonBy = By.LinkText("Twitter");

        private readonly By _facebookButtonBy = By.LinkText("Facebook");

        private readonly By _linkedInButtonBy = By.LinkText("LinkedIn");


        // Инициализация класса

        public ShoppingCartPage(IWebDriver driver, bool openPageByUrl, bool isItemsInCart) : base(driver, openPageByUrl)
        {
            _isItemsInCart = isItemsInCart;
        }

        public ShoppingCartPage(IWebDriver driver, bool isItemsInCart) : base(driver, false)
        {
            _isItemsInCart = isItemsInCart;
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
        public IWebElement CheckoutButton => Driver.FindElement(_checkoutButtonBy);
        public IWebElement ContinueShoppingButton => Driver.FindElement(_continueShoppingButtonBy);

        public List<IWebElement> ItemsList
        {
            get
            {
                if (_isItemsInCart)
                {
                    return new List<IWebElement>(Driver.FindElements(_itemsListBy));
                }
                else
                {
                    throw new Exception("The shopping cart is empty.");
                }
            }
        }

        public IWebElement ShoppingCartButton => Driver.FindElement(_shoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(_menuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(_twitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(_facebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(_linkedInButtonBy);
    }
}