using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;

namespace PageObject.Steps
{
    public class SortItemsStep : BaseStep
    {
        public ProductsPage ProductsPage;

        public SortItemsStep(IWebDriver driver) : base(driver)
        {
        }

        public void SortByNameAZ()
        {
            ProductsPage = new ProductsPage(Driver);
            ProductsPage.ProductSortSelect.SelectByValue("az" + "");
        }

        public void SortByNameZA()
        {
            ProductsPage = new ProductsPage(Driver);
            ProductsPage.ProductSortSelect.SelectByValue("az" + "");
        }

        public void SortByPriceLowToHigh()
        {
            ProductsPage = new ProductsPage(Driver);
            ProductsPage.ProductSortSelect.SelectByValue("lohi");
        }

        public void SortByPriceHighToLow()
        {
            ProductsPage = new ProductsPage(Driver);
            ProductsPage.ProductSortSelect.SelectByValue("hilo");
        }
    }
}