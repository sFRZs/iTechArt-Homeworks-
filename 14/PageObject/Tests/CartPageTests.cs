using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PageObject.BaseEntities;


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
            AddItemStep.AddItemsToCart(2);
            RemoveStep.RemoveItems(1);

            Assert.AreEqual(1, RemoveStep.CartPage.ItemsList.Count);
        }
    }
}