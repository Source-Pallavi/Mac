using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Trainbooking.Pages
{
  public  class BuyPhone
    {
        public IWebDriver driver;
        //pom constructor
        public BuyPhone(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//label[@id='Item15_8inch_label']//span[@class='form-choiceselectorlabel-twocol']")]
        public IWebElement Model;
        [FindsBy(How = How.Id, Using = "dimensionColor-silver")]
        public IWebElement Colour;
        [FindsBy(How = How.Id, Using = "Item3-dimensionCapacity-256gb")]
        public IWebElement Capacity;
        [FindsBy(How = How.Id, Using = "Item3-dimensionCapacity-256gbItem50_label")]
        public IWebElement Transport;

        public void specification()
        {
            Thread.Sleep(2000);
            Model.Click();
            Colour.Click();
            Capacity.Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Transport.Click();
            Thread.Sleep(2000);


        }
    }
}
