using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PageObject.BaseEntities;
using PageObject.Steps;

namespace PageObject.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("CartTest")]
    public class CartPageTests : BaseTest
    {
        [Test]
        [AllureTag("StandardUser")]
        public void RemoveItemFromCartTest()
        {
            AddItemToCartStep addItem = new AddItemToCartStep(Driver);
            addItem.AddItemsToCart(2);

            RemoveItemsFromCartStep removeStep = new RemoveItemsFromCartStep(Driver);
            removeStep.RemoveItems(1);

            Assert.AreEqual(1, removeStep.CartPage.ItemsList.Count);
        }
    }
}