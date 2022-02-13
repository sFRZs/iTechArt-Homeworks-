using OpenQA.Selenium;
using Task1.BaseEntities;

namespace Task1.Pages
{
    public class MainPage : BasePage
    {
        private static string END_POINT = "";

        private static readonly By FastSearchBy = By.ClassName("fast-search__input");
        
        public MainPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }
        
        public MainPage(IWebDriver driver) : base(driver, false)
        {
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public IWebElement FastSearch => WaitServices.GetVisibleElement(FastSearchBy);
    }
}