using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages
{
    public class LoginPage : BasePage
    {
        private  string END_POINT = "";

        // Описание элементов
        private  readonly By _userNameInputBy = By.Id("user-name");

        private  readonly By _passwordInputBy = By.Id("password");

        private  readonly By _logInButtonBy = By.Id("login-button");

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
        public IWebElement UserNameInput => Driver.FindElement(_userNameInputBy);
        public IWebElement PasswordInput => Driver.FindElement(_passwordInputBy);
        public IWebElement LogInButton => Driver.FindElement(_logInButtonBy);
    }
}