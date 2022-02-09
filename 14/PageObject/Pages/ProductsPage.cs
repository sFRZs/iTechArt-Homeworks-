using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObject.BaseEntities;

namespace PageObject.Pages
{
    public class ProductsPage : BasePage
    {
        private static string END_POINT = "inventory.html";

        // Описание элементов

        private static readonly By ProductSortSelectBy = By.ClassName("product_sort_container");

        private static readonly By InventoryItemsBy = By.ClassName("inventory_item");

        private static readonly By ShoppingCartButtonBy = By.Id("shopping_cart_container");

        private static readonly By MenuButtonBy = By.Id("react-burger-menu-btn");

        private static readonly By TwitterButtonBy = By.LinkText("Twitter");

        private static readonly By FacebookButtonBy = By.LinkText("Facebook");

        private static readonly By LinkedInButtonBy = By.LinkText("LinkedIn");


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
        private IWebElement ProductSortElement => Driver.FindElement(ProductSortSelectBy);
        public SelectElement ProductSortSelect => new SelectElement(ProductSortElement);

        public List<IWebElement> InventoryItemsList =>
            new List<IWebElement>(Driver.FindElements(InventoryItemsBy));

        public IWebElement ShoppingCartButton => Driver.FindElement(ShoppingCartButtonBy);
        public IWebElement MenuButton => Driver.FindElement(MenuButtonBy);
        public IWebElement TwitterButton => Driver.FindElement(TwitterButtonBy);
        public IWebElement FacebookButton => Driver.FindElement(FacebookButtonBy);
        public IWebElement LinkedInButton => Driver.FindElement(LinkedInButtonBy);

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