using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using Task1.Services;

namespace Task1.BaseEntities
{
    public abstract class BasePage
    {
        [ThreadStatic] protected static IWebDriver Driver;

        protected static WaitServices WaitServices;
        // private static int WAIT_FOR_PAGE_LOADING_TIME = Configurator.TimeOut;

        public BasePage(IWebDriver driver, bool openPageByUrl)
        {
            Driver = driver;
            WaitServices = new WaitServices(driver);

            if (openPageByUrl)
            {
                OpenPage();
            }

            WaitServices.WaitForPageOpen();
        }

        protected abstract void OpenPage();

        public bool IsPageOpened() 
        {
            var result = ((IJavaScriptExecutor) Driver).ExecuteScript("return document.readyState");
            return result.Equals("complete");
        }


        // private void WaitForOpen()
        // {
        //     // var secondsCount = 0;
        //     // var isPageOpenedIndicator = IsPageOpened();
        //     // while (!isPageOpenedIndicator && secondsCount < WAIT_FOR_PAGE_LOADING_TIME)
        //     // {
        //     //     Thread.Sleep(1000);
        //     //     secondsCount++;
        //     //     isPageOpenedIndicator = IsPageOpened();
        //     // }
        //
        //     if (!IsPageOpened())
        //     {
        //         throw new AssertionException("Page was not opened.");
        //     }
        // }
    }
}