using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObject.BaseEntities;

namespace PageObject.Pages
{
    public class ProductsPage : BasePage
    {
        private string END_POINT = "inventory.html";

        // Описание элементов

        private readonly By _productSortSelectBy = By.ClassName("product_sort_container");

        private readonly By _inventoryItemsBy = By.ClassName("inventory_item");

        private readonly By _shoppingCartButtonBy = By.Id("shopping_cart_container");

        private readonly By _menuButtonBy = By.Id("react-burger-menu-btn");

        private readonly By _twitterButtonBy = By.LinkText("Twitter");

        private readonly By _facebookButtonBy = By.LinkText("Facebook");

        private readonly By _linkedInButtonBy = By.LinkText("LinkedIn");


        // Инициализация класса

        public ProductsPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public ProductsPage(IWebDriver driver) : base(driver, false)
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
                return ProductSortElement.Displayed;
            }

            catch (Exception e)
            {
                return false;
            }
        }

        // Методы
        private IWebElement ProductSortElement => Driver.FindElement(_productSortSelectBy);
        public SelectElement ProductSortSelect => new SelectElement(ProductSortElement);

        public List<IWebElement> InventoryItemsList =>
            new List<IWebElement>(Driver.FindElements(_inventoryItemsBy));

        public IWebElement ShoppingCartButton => Driver.FindElement(_shoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(_menuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(_twitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(_facebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(_linkedInButtonBy);

        public int GetCartItemsCount()
        {
            try
            {
                var cartItems = ShoppingCartButton.FindElement(By.ClassName("shopping_cart_badge"));
                //object cartItemsCount = int.Parse(cartItems.GetAttribute("innerText"));
                // return (int) cartItemsCount;
                return int.Parse(cartItems.GetAttribute("innerText"));
            }

            catch (Exception e)
            {
                Console.Out.WriteLine($"Error: {e.Message}");
                return 0;
            }
        }
    }
}