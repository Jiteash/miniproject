using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using miniproject.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using miniproject.TestdataAccess;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.Threading;



namespace miniproject.Stepdefinition
{
    [Binding]
    public sealed class Testfeature
    {
        //private readonly HomePage homepage;
        //private readonly Loginpage loginpage;

        IWebDriver driver = new FirefoxDriver();
        #region Given
        [Given(@"user is at home page")]
        public void GivenUserIsAtHomePage()
        {
            driver.Url = ConfigurationManager.AppSettings["URL"];
            //WhenIProvideUsernameAndPasswordAndClickLoginButton();
            //ThenUserShouldBeAtMainPage();
            //ThenVerifyTitle();

        }
        #endregion


        #region When
        [When(@"i provide username and password and click login button")]
        public void WhenIProvideUsernameAndPasswordAndClickLoginButton()
        {
            var loginpage = new Loginpage(driver);
            loginpage.loginapplication("LoginTest");

        }
        #endregion
        #region Then
        [Then(@"user should be at main page")]
        public void ThenUserShouldBeAtMainPage()
        {
            var homepage = new HomePage(driver);
            homepage.clickonhomepage();            
            Console.WriteLine("Here");

        }
        #endregion

        [Then(@"verify title")]
        public void ThenVerifyTitle()
        {
            Assert.AreEqual("OrangeHRM", driver.Title);
            Console.WriteLine("Test Passed");
            Thread.Sleep(5000);
            driver.Close();
        }

    }
}
