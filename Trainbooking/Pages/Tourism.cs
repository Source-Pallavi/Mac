using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Trainbooking.Pages
{
    public class Tourism
    {
        public IWebDriver driver;
        //pom constructor
        public Tourism(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Land Package')]")]
        public IWebElement landPackage;
        public void Options()
        {
            landPackage.Click();
        }
    }
    }
