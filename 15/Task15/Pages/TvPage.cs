using System.Collections.Generic;
using OpenQA.Selenium;
using Task1.BaseEntities;


namespace Task1.Pages
{
    public class TvPage : BasePage
    {
        private string END_POINT = "tv";

        private readonly By _tvListBy = By.ClassName("schema-product__group");

        private readonly By _productsComparisonButtonBy = By.ClassName("compare-button__sub_main");

        private readonly By _appleStoreLinkBy = By.CssSelector("a.schema-filter__store-item.schema-filter__store-item_apple");

        private readonly By _googlePlayLinkBy = By.CssSelector("a.schema-filter__store-item.schema-filter__store-item_google");


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

        public override bool IsPageOpened()
        {
            var titleElement = WaitService.GetVisibleElement(By.ClassName("schema-header__title"));
            var title = titleElement.GetAttribute("textContent");

            return title.Equals("Телевизоры");
        }


        public List<IWebElement> TvList => WaitService.GetVisibleElements(_tvListBy);
        public IWebElement ProductsComparisonButton => WaitService.GetVisibleElement(_productsComparisonButtonBy);
        public IWebElement AppleStoreLink => WaitService.GetVisibleElement(_appleStoreLinkBy);
        public IWebElement GooglePlayLink => WaitService.GetVisibleElement(_googlePlayLinkBy);
    }
}