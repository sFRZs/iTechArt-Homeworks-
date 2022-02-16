using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.Services;
using PageObject.Steps;

namespace PageObject.BaseEntities
{
    public class BaseTest
    {
        public static readonly string BaseUrl = Configurator.BaseUrl;

        protected IWebDriver Driver;
        protected AddItemToCartStep AddItemStep;
        protected ConfirmOrderStep OrderStep;
        protected LoginStep LoginStep;
        protected RemoveItemsFromCartStep RemoveStep;
        protected SortItemsStep SortStep;

        [SetUp]
        public void Setup()
        {
            Driver = new BrowserServices().WebDriver;
            AddItemStep = new AddItemToCartStep(Driver);
            OrderStep = new ConfirmOrderStep(Driver);
            LoginStep = new LoginStep(Driver);
            RemoveStep = new RemoveItemsFromCartStep(Driver);
            SortStep = new SortItemsStep(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}