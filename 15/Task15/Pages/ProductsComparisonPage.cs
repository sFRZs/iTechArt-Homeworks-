using System.Collections.Generic;
using OpenQA.Selenium;
using Task1.BaseEntities;

namespace Task1.Pages
{
    public class ProductsComparisonPage : BasePage
    {
        private string END_POINT = "cart.html";
        
        private readonly By _screenDiagonalBy = By.XPath("//span[contains(text(),'Диагональ экрана')]");

        private readonly By _screenDiagonalTipButtonBy = By.XPath("//*[@id='product-table']/tbody[5]/tr[4]/td[1]/div/span");

        private readonly By _comparisonItemsListBy = By.ClassName("cart_item");

        
       public ProductsComparisonPage(IWebDriver driver) : base(driver, false)
        {
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            var element = WaitService.GetVisibleElement(By.ClassName("b-offers-title"));
            var elementText = element.GetAttribute("textContent");
            return elementText.Equals("Сравнение товаров");
        }


        // Методы
        public IWebElement ScreenDiagonal => WaitService.GetVisibleElement(_screenDiagonalBy);
        public IWebElement ScreenDiagonalTipButton => WaitService.GetVisibleElement(_screenDiagonalTipButtonBy);

        public List<IWebElement> ComparisonItemsList => WaitService.GetVisibleElements(_comparisonItemsListBy);
    }
}