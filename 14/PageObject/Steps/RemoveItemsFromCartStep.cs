using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;

namespace PageObject.Steps
{
    public class RemoveItemsFromCartStep : BaseStep
    {
        public ShoppingCartPage CartPage;

        public RemoveItemsFromCartStep(IWebDriver driver) : base(driver)
        {
        }

        public void RemoveItems(int numberOfProducts)
        {
            CartPage = new ShoppingCartPage(Driver, true, true);

            if (numberOfProducts >= 0 && numberOfProducts <= CartPage.ItemsList.Count)
            {
                for (int i = 0; i < numberOfProducts; i++)
                {
                    var item = CartPage.ItemsList[i];
                    var removeButton = item.FindElement(By.CssSelector("button[name^='remove']"));
                    removeButton.Click();
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}