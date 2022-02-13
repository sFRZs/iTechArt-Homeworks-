
using System.Threading;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using OpenQA.Selenium;
using Task1.BaseEntities;
using Task1.Pages;
using Task1.Services;


namespace Task1.Tests
{
    public class Task2 : BaseTest
    {
        private ILogger<Task2> _logger = new MyLogger<Task2>().Logger;
        [Test]
        public void SecondTaskTest()
        {
            // Opening all needs page.

            var tvPage = new TvPage(Driver, true);
            var tvPageHandle = Driver.WindowHandles[^1];
            
            tvPage.AppleStoreLink.Click();
            var appStoreHandle = Driver.WindowHandles[^1];
            
            tvPage.GooglePlayLink.Click();
            var googlePlayHandle = Driver.WindowHandles[^1];
            
            Assert.AreEqual(3, Driver.WindowHandles.Count);
            
            
            // Work with GooglePlay page.

            Driver.SwitchTo().Window(googlePlayHandle);
            var actionAppName = WaitServices.GetVisibleElement(By.CssSelector("div.sIskre > c-wiz:nth-child(1) > h1 > span"));
            StringAssert.AreEqualIgnoringCase("Каталог Onliner", actionAppName.GetAttribute("textContent"));
            
            var moreGoogleAppButton = WaitServices.GetVisibleElement(By.CssSelector("div.W9yFB > a"));
            moreGoogleAppButton.Click();
            Thread.Sleep(1000);
            _logger.LogInformation($"Number of similar applications in GooglePlay: {WaitServices.GetVisibleElements(By.CssSelector("div.ZmHEEd > div.ImZGtf")).Count}");

            // Work with AppStore page.

            Driver.SwitchTo().Window(appStoreHandle);
            var moreButton = WaitServices.GetVisibleElement(By.ClassName("we-truncate__button"));
            moreButton.Click();
            Driver.Close();

            // Other

            Driver.SwitchTo().Window(tvPageHandle);
            var addBanner = Driver.FindElement(By.ClassName("schema-block"));
            addBanner.Click();
            foreach (var window in Driver.WindowHandles)
            {
                Driver.SwitchTo().Window(window).Close();
            }
        }
    }
}