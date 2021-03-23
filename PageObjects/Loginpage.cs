using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using miniproject.PageObjects;
using miniproject.TestdataAccess;

namespace miniproject.PageObjects
{
    public class Loginpage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "txtUsername")]
        private IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement password { get; set; }

        [FindsBy(How= How.Id, Using = "btnLogin")]
        private IWebElement click { get; set; }

        public Loginpage (IWebDriver driver)
        {
            this.driver = driver;
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public void loginapplication(string testname)
        {
           
            var userdata = ExceldataAccess.GetUserdata(testname);
            Username.SendKeys(userdata.Username);
            password.SendKeys(userdata.password);
         
            //Username.SendKeys("admin");
            //password.SendKeys("admin123");
            click.Submit();

        }

    }
}
