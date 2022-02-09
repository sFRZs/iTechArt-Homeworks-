using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.Services;

namespace PageObject.BaseEntities
{
    public class BaseTest
    {
        public static readonly string BaseUrl = Configurator.BaseUrl;

        [ThreadStatic] protected static IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new BrowserServices().WebDriver;
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}