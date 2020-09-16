using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trainbooking.Base
{
   public class BaseClass
    {
        IWebDriver driver = null;
        ChromeOptions optionss = new ChromeOptions();

        public IWebDriver StartBrowser(String browserName)
        {
            //browser factory
            try
            {
                optionss.AddArgument(@"--incognito");
                if (browserName.ToLower().Equals("")) throw (new Exception("BROWSER_NAME is not specified"));
                if (browserName.ToLower().Equals("chrome")) driver = new ChromeDriver(optionss);//return chrome driver
                if (browserName.ToLower().Equals("firefox")) driver = new FirefoxDriver();//return firefox driver
            }
            catch (Exception e)
            {
                throw (new Exception("BROWSER_NAME is not specified"));
            }
            driver.Url = "https://www.apple.com/mac/";//initializing url
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();//maximizing the window
            return driver;//returns the driver
        }
    }
}
