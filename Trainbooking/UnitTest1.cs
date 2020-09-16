using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using Trainbooking.Base;
using Trainbooking.Pages;

namespace Trainbooking
{
    [TestFixture("chrome")]
    public class UnitTest1 : BaseClass
    {
        IWebDriver driver;
        public UnitTest1(string browserName)
        {
            driver = StartBrowser("chrome");
        }
        [Test ,Order(1)]
        public void TestMethod1()
        {
            Homepage homepage = new Homepage(driver);
            homepage.homePage();
        }
        [Test, Order(2)]
        public void TestMethod2()
        {
            Tourism pack = new Tourism(driver);
          //  pack.Options();

        }
        [TearDown]
    public void close_Browser()
    {
       driver.Quit();
    }
}
}
