using OpenQA.Selenium;
using Task1.BaseEntities;

namespace Task1.Pages
{
    public class MainPage : BasePage
    {
        private readonly By _fastSearchBy = By.ClassName("fast-search__input");
        private readonly By _newsAndCatalogLayerBy = By.ClassName("b-main-page-catalog-layer");

        public MainPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public MainPage(IWebDriver driver) : base(driver, false)
        {
        }


        public override bool IsPageOpened()
        {
            return NewsAndCatalogLayer.Displayed;
        }

        public IWebElement FastSearch => WaitService.GetVisibleElement(_fastSearchBy);
        public IWebElement NewsAndCatalogLayer => WaitService.GetVisibleElement(_newsAndCatalogLayerBy);
    }
}