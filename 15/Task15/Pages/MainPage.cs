using System;
using OpenQA.Selenium;
using Task1.BaseEntities;

namespace Task1.Pages
{
    public class MainPage : BasePage
    {
        private readonly By _fastSearchBy = By.ClassName("fast-search__input");
        private readonly By _catalogButtonBy = By.LinkText("Каталог");

        public MainPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public MainPage(IWebDriver driver) : base(driver, false)
        {
        }


        public override bool IsPageOpened()
        {
            try
            {
                return CatalogButton.Displayed;
            }
            catch (Exception e)
            {

                return false;
            }
          
        }

        public IWebElement FastSearch => WaitService.GetVisibleElement(_fastSearchBy);
        public IWebElement CatalogButton => WaitService.GetVisibleElement(_catalogButtonBy);
    }
}