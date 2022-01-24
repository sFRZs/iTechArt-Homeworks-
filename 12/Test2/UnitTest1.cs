using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Test2
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
            _driver.Navigate().GoToUrl(@"https://www.calc.ru/kalkulyator-kalorii.html");
            Thread.Sleep(2000);

            IWebElement element1 = _driver.FindElement(By.Id("activity"));
            SelectElement select = new SelectElement(element1);
            select.SelectByValue("1.4625");

            IWebElement age = _driver.FindElement(By.Id("age"));
            age.SendKeys("35");

            IWebElement weight = _driver.FindElement(By.Id("weight"));
            weight.SendKeys("85");

            IWebElement height = _driver.FindElement(By.Id("sm"));
            height.SendKeys("185");
            
            IWebElement button = _driver.FindElement(By.Id("submit"));
            button.Click();

            Thread.Sleep(2000);
            
            IWebElement result = _driver.FindElement(By.XPath("//div[@class='block_content']/table/tbody/tr[2]/td"));
            Assert.AreEqual("3028 ккал/день", result.GetAttribute("innerText"));
        }
    }
}