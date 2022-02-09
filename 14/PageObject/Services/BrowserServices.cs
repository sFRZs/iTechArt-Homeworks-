using System;
using OpenQA.Selenium;

namespace PageObject.Services
{
    public class BrowserServices
    {
        public IWebDriver WebDriver { get; }

        public BrowserServices()
        {
            WebDriver = Configurator.BrowserType.ToLower() switch
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                "firefox" => new DriverFactory().GetFireFoxDriver(),
                "brave" => new DriverFactory().GetBraveDriver(),
                _ => WebDriver
            };

            WebDriver.Manage().Window.Maximize();
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    }
}