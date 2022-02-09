using System;
using System.Collections.Generic;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Services;
using PageObject.Steps;

namespace PageObject.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("ProductPageTests")]
    public class ProductsTest : BaseTest
    {
        [TestCase(2)]
        [TestCase(6)]
        [AllureTag("StandardUser")]
        public void AddItemToCartTest(int numberOfProducts)
        {
            var addItemStep = new AddItemToCartStep(Driver);
            addItemStep.AddItemsToCart(numberOfProducts);

            Assert.AreEqual(numberOfProducts, addItemStep.ProductsPage.GetCartItemsCount());
        }

        [Test]
        [AllureTag("StandardUser")]
        public void PurchaseOfTwoProductsTest()
        {
            var addItemStep = new AddItemToCartStep(Driver);
            addItemStep.AddItemsToCart(2);

            var orderStep = new ConfirmOrderStep(Driver);
            orderStep.Confirm();

            var completeTitle = Driver.FindElement(By.ClassName("title"));
            Assert.AreEqual("Checkout: Complete!", completeTitle.GetAttribute("textContent"));
        }

        [Test]
        [AllureTag("StandardUser")]
        public void SortByPriceLowToHighTest()
        {
            var loginStep = new LoginStep(Driver);
            loginStep.Login(UsersConfigurator.StandardUserName, UsersConfigurator.Password);

            var sortStep = new SortItemsStep(Driver);
            sortStep.SortByPriceLowToHigh();

            Assert.IsTrue(IsSortedByPrice(sortStep.ProductsPage.InventoryItemsList));
        }

        private bool IsSortedByPrice(List<IWebElement> items)
        {
            for (int i = 0; i < items.Count - 1; i++)
            {
                var el1 = Double.Parse(items[i].FindElement(By.ClassName("inventory_item_price"))
                    .GetAttribute("textContent").Remove(0, 1).Replace('.', ','));
                var el2 = Double.Parse(items[i + 1].FindElement(By.ClassName("inventory_item_price"))
                    .GetAttribute("textContent")
                    .Remove(0, 1)
                    .Replace('.', ','));

                if (el1 > el2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}