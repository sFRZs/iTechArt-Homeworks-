using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using Task1.Services;

namespace Task1.BaseEntities
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;

        protected readonly WaitServices WaitService;

        public BasePage(IWebDriver driver, bool openPageByUrl)
        {
            Driver = driver;
            WaitService = new WaitServices(driver);

            if (openPageByUrl)
            {
                OpenPage();
            }

           WaitForOpen();
        }

        protected virtual void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl);
        }

        public abstract bool IsPageOpened();

        private void WaitForOpen()
        {
            var secondsCount = 0;
            var isPageOpenedIndicator = IsPageOpened();
            while (!isPageOpenedIndicator && secondsCount < Configurator.TimeOut)
            {
                Thread.Sleep(1000);
                secondsCount++;
                isPageOpenedIndicator = IsPageOpened();
            }

            if (!isPageOpenedIndicator)
            {
                throw new AssertionException("Page was not opened.");
            }
        }
    }
}