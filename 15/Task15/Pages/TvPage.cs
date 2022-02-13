using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Task1.BaseEntities;

namespace Task1.Pages
{
    public class TvPage : BasePage
    {
        private static string END_POINT = "tv";

        // Описание элементов
        private static readonly By TvListBy = By.ClassName("schema-product__group");
        
        private static readonly By ProductsComparisonButtonBy = By.ClassName("compare-button__sub_main");

        private static readonly By AppleStoreLinkBy = By.CssSelector("a.schema-filter__store-item.schema-filter__store-item_apple");

        private static readonly By GooglePlayLinkBy = By.CssSelector("a.schema-filter__store-item.schema-filter__store-item_google");

        // Инициализация класса
        public TvPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public TvPage(IWebDriver driver) : base(driver, false)
        {
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }
        

        // Методы
        public List<IWebElement> TvList => WaitServices.GetVisibleElements(TvListBy);
        public IWebElement ProductsComparisonButton => WaitServices.GetVisibleElement(ProductsComparisonButtonBy);
        public IWebElement AppleStoreLink => WaitServices.GetVisibleElement(AppleStoreLinkBy);
        public IWebElement GooglePlayLink => WaitServices.GetVisibleElement(GooglePlayLinkBy);
    }
}