using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;
using PageObject.Services;
using PageObject.Steps;

namespace PageObject.Tests
{
   
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("LoginTest")]
    public class LoginTests : BaseTest
    {
        [Test]
        [AllureTag("StandardUser")]
        public void StandardUserLoginTest()
        {
            var loginSteps = new LoginStep(Driver);
            loginSteps.Login(UsersConfigurator.StandardUserName, UsersConfigurator.Password);
            
            Assert.IsTrue(new ProductsPage(Driver).IsPageOpened());
            StringAssert.AreEqualIgnoringCase("Swag Labs", Driver.Title);
            Assert.IsNotEmpty(new ProductsPage(Driver).InventoryItemsList);
        } 
        
        [Test]
        [AllureTag("LockedOutUser")]
        public void LockedOutUserLoginTest()
        {
            var loginSteps = new LoginStep(Driver);
            loginSteps.Login(UsersConfigurator.LockedOutUserName, UsersConfigurator.Password);

            var errorElement = Driver.FindElement(By.ClassName("error-message-container"));
            var action = errorElement.GetAttribute("textContent");
            var expectedResult = "Epic sadface: Sorry, this user has been locked out.";
            
            StringAssert.AreEqualIgnoringCase(expectedResult, action);
        } 
    }
}