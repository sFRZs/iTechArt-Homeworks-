using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";

        // Описание элементов
        private static readonly By UserNameInputBy = By.Id("user-name");

        private static readonly By PasswordInputBy = By.Id("password");

        private static readonly By LogInButtonBy = By.Id("login-button");

        // Инициализация класса
        public LoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public LoginPage(IWebDriver driver) : base(driver, false)
        {
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return LogInButton.Displayed;
            }

            catch (Exception e)
            {
                return false;
            }
        }

        // Методы
        public IWebElement UserNameInput => Driver.FindElement(UserNameInputBy);
        public IWebElement PasswordInput => Driver.FindElement(PasswordInputBy);
        public IWebElement LogInButton => Driver.FindElement(LogInButtonBy);
    }
}