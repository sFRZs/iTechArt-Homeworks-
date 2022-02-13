using OpenQA.Selenium;
using Task1.BaseEntities;

namespace Task1.Pages
{
    public class ProductsComparisonPage : BasePage
    {
        private static string END_POINT = "cart.html";
       

        // Описание элементов

        private static readonly By ScreenDiagonalBy = By.XPath("//span[contains(text(),'Диагональ экрана')]");

       // private static readonly By ScreenDiagonalTipButtonBy  = By.XPath("(//span[contains(text(),'Диагональ экрана')]/following::span[@class='product-table-tip__trigger'])[1]");
        private static readonly By ScreenDiagonalTipButtonBy  = By.XPath("//*[@id='product-table']/tbody[5]/tr[4]/td[1]/div/span");

        private static readonly By ItemsListBy = By.ClassName("cart_item");




        // Инициализация класса

        // public ProductsComparisonPage(IWebDriver driver, bool openPageByUrl, bool isItemsInCart) : base(driver, openPageByUrl)
        // {
        //     _isItemsInCart = isItemsInCart;
        // }

        public ProductsComparisonPage(IWebDriver driver) : base(driver, false)
        {
           
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

       

        // Методы
        public IWebElement ScreenDiagonal => WaitServices.GetVisibleElement(ScreenDiagonalBy);
        public IWebElement ScreenDiagonalTipButton => WaitServices.GetVisibleElement(ScreenDiagonalTipButtonBy);

        // public List<IWebElement> ItemsList
        // {
        //     get
        //     {
        //         if (_isItemsInCart)
        //         {
        //             return new List<IWebElement>(Driver.FindElements(ItemsListBy));
        //         }
        //         else
        //         {
        //             throw new Exception("The shopping cart is empty.");
        //         }
        //     }
        // }


    }
}