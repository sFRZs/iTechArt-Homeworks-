using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.Services;
using Task1.Services;

namespace Task1.BaseEntities
{
    public class BaseTest
    {
        public static readonly string BaseUrl = Configurator.BaseUrl;
        protected WaitServices WaitServices;

        [ThreadStatic] protected static IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new BrowserServices().WebDriver;
            WaitServices = new WaitServices(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}