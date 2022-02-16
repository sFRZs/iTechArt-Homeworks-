using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.Services;
using Task1.Services;
using Task1.Steps;

namespace Task1.BaseEntities
{
    public class BaseTest
    {
        public static readonly string BaseUrl = Configurator.BaseUrl;
        protected WaitServices WaitServices;
        protected  IWebDriver Driver;
        
        protected  AddItemsToComparisonStep AddItemsStep;

        [SetUp]
        public void Setup()
        {
            Driver = new BrowserServices().WebDriver;
            WaitServices = new WaitServices(Driver);
            AddItemsStep = new AddItemsToComparisonStep(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}