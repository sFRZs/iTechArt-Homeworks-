using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Test1
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files (x86)\BraveSoftware\Brave-Browser\Application\brave.exe";
            _driver = new ChromeDriver(options);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl(@"https://calc.by/building-calculators/laminate.html");
            Thread.Sleep(5000);

            IWebElement sElement = _driver.FindElement(By.Id("laying_method_laminate"));
            SelectElement select = new SelectElement(sElement);
            select.SelectByIndex(2);

            IWebElement roomLength = _driver.FindElement(By.Id("ln_room_id"));
            roomLength.Clear();
            roomLength.SendKeys("500");

            IWebElement roomWidth = _driver.FindElement(By.Id("wd_room_id"));
            roomWidth.Clear();
            roomWidth.SendKeys("400");

            IWebElement laminateLength = _driver.FindElement(By.Id("ln_lam_id"));
            laminateLength.Clear();
            laminateLength.SendKeys("2000");

            IWebElement laminateWidth = _driver.FindElement(By.Id("wd_lam_id"));
            laminateWidth.Clear();
            laminateWidth.SendKeys("200");

            IWebElement layingDirection = _driver.FindElement(By.Id("direction-laminate-id1"));
            layingDirection.Click();
            
            IWebElement button = _driver.FindElement(By.LinkText("Рассчитать"));
            button.Click();

            Thread.Sleep(2000);
            
            IWebElement element1 = _driver.FindElement(By.XPath("//div[@class='calc-result']/div/span[contains(text(), '53')]"));
            IWebElement element2 = _driver.FindElement(By.XPath("//div[@class='calc-result']/div/span[contains(text(), '7')]"));
        }
    }
}