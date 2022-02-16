using OpenQA.Selenium;

namespace PageObject.BaseEntities
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