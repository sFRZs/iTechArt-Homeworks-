using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;

namespace PageObject.Steps
{
    public class LoginStep : BaseStep
    {
        public LoginStep(IWebDriver driver) : base(driver)
        {
        }

        public void Login(string userName, string password)
        {
            var loginPage = new LoginPage(Driver, true);
            loginPage.UserNameInput.SendKeys(userName);
            loginPage.PasswordInput.SendKeys(password);
            loginPage.LogInButton.Click();
        }
    }
}