using OpenQA.Selenium;
using Task1.BaseEntities;
using Task1.Pages;

namespace Task1.Steps
{
    public class AddItemsToComparisonStep : BaseStep
    {
        public TvPage TvPage;

        public AddItemsToComparisonStep(IWebDriver driver) : base(driver)
        {
        }

        public void AddItems(int count)
        {
            TvPage = new TvPage(Driver, true);
            for (int i = 0; i < count; i++)
            {
                var checkBoxTv = TvPage.TvList[i].FindElement(By.ClassName("schema-product__compare"));
                checkBoxTv.Click();
            }
        }
    }
}