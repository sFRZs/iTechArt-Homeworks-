using System;
using OpenQA.Selenium;

namespace Task1.BaseEntities
{
    public class BaseStep
    {
        [ThreadStatic] protected static IWebDriver Driver;

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}