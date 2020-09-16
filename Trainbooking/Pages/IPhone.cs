using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Trainbooking.Logger;

namespace Trainbooking.Pages
{
    public class IPhone
    {
        public IWebDriver driver;
        //pom constructor
        public IPhone(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[@class='chapternav-label'][contains(text(),'Compare')]")]
        public IWebElement compare;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Land Package')]")]
        public IWebElement Compare;

        public object WriteLogFile { get; private set; }

        public void Options()
        {
            Thread.Sleep(2000);
            compare.Click();
            LogTheData.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Log is Created at", DateTime.Now));
        }
    }
    }
