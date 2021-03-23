using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;
using miniproject.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using OpenQA.Selenium.Firefox;

namespace miniproject.TestCases
{
    class LoginTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];

            var loginpage = new Loginpage(driver);
            loginpage.loginapplication("LoginTest");

            var homepage = new HomePage(driver);
            homepage.clickonhomepage();

            //driver.Close();





            //driver.FindElement(By.Id("txtUsername")).SendKeys("admin");
            //driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            //driver.FindElement(By.Id("btnLogin")).Click();
            //string mytitle = driver.Title;
            //Console.WriteLine("The Title page is" + mytitle);
            //Thread.Sleep(2000);
            //driver.Manage().Window.Maximize();
            //Thread.Sleep(3000);
            //driver.Close();


        }
    }
}
