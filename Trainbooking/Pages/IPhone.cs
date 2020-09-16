using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
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
        [FindsBy(How = How.ClassName, Using = "compare-row")]
        public IList<IWebElement> features { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='compare-column compare-column-one']//a[@class='button'][contains(text(),'Buy')]")]
        public IWebElement buy;


        public void Options()
        {
            Thread.Sleep(2000);
            compare.Click();
            LogTheData.WriteLog("ConsoleLog",  features);
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,100)");
            buy.Click();


        }
    }
    }
