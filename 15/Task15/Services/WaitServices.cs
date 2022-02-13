using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Task1.BaseEntities;

namespace Task1.Services
{
    public class WaitServices
    {
        public WebDriverWait Wait;

        public WaitServices(IWebDriver driver)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Configurator.TimeOut));
        }

        public IWebElement GetVisibleElement(By by)
        {
            try
            {
                return Wait.Until(d => d.FindElement(by));
            }
            catch (Exception e)
            {
                throw new AssertionException(e.Message, e);
            }
        }

        public List<IWebElement> GetVisibleElements(By by)
        {
            try
            {
                return new List<IWebElement>(Wait.Until(d => d.FindElements(by)));
            }
            catch (Exception e)
            {
                throw new AssertionException(e.Message, e);
            }
        }

        public bool InvisibilityOfElementLocated(By by)
        {
            try
            {
                return !(Wait.Until(d => d.FindElement(by))).Displayed;
            }
            catch (NoSuchElementException e)
            {
                return true;
            }
            catch (StaleElementReferenceException e)
            {
                return true;
            }
        }

        public void WaitForPageOpen()
        {
            bool isPageOpened = Wait.Until(d =>
            {
                var result = ((IJavaScriptExecutor) d).ExecuteScript("return document.readyState");
                return result.Equals("complete");
            });
            
            if (!isPageOpened)
            {
                throw new AssertionException("Page was not opened.");
            }
        }

        public void WaitForPageRefresh(BasePage page)
        {
            Wait.Until(d =>
            {
                d.Navigate().Refresh();
                return page.IsPageOpened();
            });
        }
    }
}