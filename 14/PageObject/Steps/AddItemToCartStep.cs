using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;
using PageObject.Services;

namespace PageObject.Steps
{
    public class AddItemToCartStep : BaseStep
    {
        public ProductsPage ProductsPage;

        public AddItemToCartStep(IWebDriver driver) : base(driver)
        {
        }

        public void AddItemsToCart(int numberOfProducts)
        {
            var loginStep = new LoginStep(Driver);
            loginStep.Login(UsersConfigurator.StandardUserName, UsersConfigurator.Password);

            ProductsPage = new ProductsPage(Driver);

            if (numberOfProducts >= 0 && numberOfProducts <= ProductsPage.InventoryItemsList.Count)
            {
                for (int i = 0; i < numberOfProducts; i++)
                {
                    var firstItem = ProductsPage.InventoryItemsList[i];
                    var addToCartButton = firstItem.FindElement(By.ClassName("btn_inventory"));
                    addToCartButton.Click();
                }
            }

            else
            {
                throw new ArgumentException();
            }
        }
    }
}