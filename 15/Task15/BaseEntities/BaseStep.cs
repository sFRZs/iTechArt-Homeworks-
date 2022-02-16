using System;
using OpenQA.Selenium;

namespace Task1.BaseEntities
{
    public class BaseStep
    {
        protected IWebDriver Driver;

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}