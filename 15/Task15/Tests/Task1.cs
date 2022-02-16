using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Task1.BaseEntities;
using Task1.Pages;
using Task1.Steps;

namespace Task1.Tests
{
    public class Task1 : BaseTest
    {
        [Test]
        public void FirstTaskTest()
        {
            AddItemsStep.AddItems(2);
            AddItemsStep.TvPage.ProductsComparisonButton.Click();

            var comparisionPage = new ProductsComparisonPage(Driver);

            ((IJavaScriptExecutor) Driver).ExecuteScript("window.scrollBy(0,200);");

            new Actions(Driver).MoveToElement(comparisionPage.ScreenDiagonal).Perform();

            new Actions(Driver).MoveToElement(comparisionPage.ScreenDiagonalTipButton).Click().Perform();
            WaitServices.GetVisibleElement(By.XPath("//*[@id='productTableTip']/div/div/p"));
            comparisionPage.ScreenDiagonalTipButton.Click();

            Assert.IsTrue(WaitServices.InvisibilityOfElementLocated(By.XPath("//*[@id='productTableTip']/div/div/p")));

            WaitServices.WaitForPageRefresh(comparisionPage);
        }
    }
}