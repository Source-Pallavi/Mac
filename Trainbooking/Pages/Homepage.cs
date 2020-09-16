using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Trainbooking.Pages
{
    class Homepage
    {
        public IWebDriver driver;
        //pom constructor
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='ac-gn-link ac-gn-link-iphone']")]
        public IWebElement iPhone;
        public void homePage()
        {
            Thread.Sleep(2000);
            iPhone.Click();
            Thread.Sleep(2000);
        }
    }
}
