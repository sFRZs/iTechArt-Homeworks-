using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObject.Services
{
    public class DriverFactory
    {
        public IWebDriver GetChromeDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--disable-gpu");
            chromeOptions.AddArguments("--disable-extensions");

            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

            new DriverManager().SetUpDriver(new ChromeConfig());

            return new ChromeDriver(chromeOptions);
        }

        public IWebDriver GetBraveDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.BinaryLocation = @"C:\Program Files (x86)\BraveSoftware\Brave-Browser\Application\brave.exe";
            chromeOptions.AddArguments("--disable-gpu");
            chromeOptions.AddArguments("--disable-extensions");

            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

            new DriverManager().SetUpDriver(new ChromeConfig());

            return new ChromeDriver(chromeOptions);
        }

        public IWebDriver GetFireFoxDriver()
        {
            var ffOptions = new FirefoxOptions();
            ffOptions.AddArguments("--disable-gpu");
            ffOptions.AddArguments("--disable-extensions");

            ffOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

            new DriverManager().SetUpDriver(new FirefoxConfig());

            return new FirefoxDriver(ffOptions);
        }
    }
}