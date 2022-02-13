using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Task1.BaseEntities;
using Task1.Pages;
using Task1.Services;

namespace Task1.Tests
{
    public class Task3 : BaseTest
    {
        [Test]
        public void ThirdTaskTest()
        {
            var mainPage = new MainPage(Driver, true);
            mainPage.FastSearch.SendKeys("тостер");
            Driver.SwitchTo().Frame(WaitServices.GetVisibleElement(By.TagName("iframe")));
            var firstProductName = WaitServices.GetVisibleElement(By.ClassName("product__title-link")).GetAttribute("textContent");

            var searchElement = Driver.FindElement(By.ClassName("search__input"));
            searchElement.Clear();
            searchElement.SendKeys(firstProductName);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(Configurator.TimeOut)).Until(d => d.FindElements(By.ClassName("product__title-link")).Count == 1);
            
            WaitServices.GetVisibleElement(By.ClassName("product__title-link")).Click();
            WaitServices.WaitForPageOpen();
         
            StringAssert.AreEqualIgnoringCase(firstProductName, WaitServices.GetVisibleElement(By.ClassName("catalog-masthead__title")).GetAttribute("innerText"));
        }
    }
}