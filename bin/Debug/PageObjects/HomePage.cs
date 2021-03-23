using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace miniproject.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "My Timesheet")]
        private IWebElement Timesheet { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(driver, this);
#pragma warning restore CS0618 // Type or member is obsolete

        }

        public void clickonhomepage()
        {
            Timesheet.Click();
            Thread.Sleep(5000);
            string title = driver.Title;
            Console.WriteLine(title);
            //driver.Close();

        }

    }
}
