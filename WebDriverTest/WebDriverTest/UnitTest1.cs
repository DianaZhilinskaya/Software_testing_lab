using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace WebDriverTest
{
    [TestClass]
    public class WebDriverTest
    {
        [TestMethod]
  
        public void TestMethod1()
        {
            RemoteWebDriver Driver = new ChromeDriver();

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

            Driver.Navigate().GoToUrl(@"https://www.lot.com/by/ru");

            var txtFirstAirport = Driver.FindElementByXPath("div[@class='b-row g-no-padding-t airports-row']//div[@class='booker-column-1']");
            var txtSecondAirport = Driver.FindElementByXPath("div[@class='b-row g-no-padding-t airports-row']//div[@class='booker-column-2']");

            txtFirstAirport.Clear();
            txtFirstAirport.SendKeys("Минск");

            txtSecondAirport.Clear();
            txtSecondAirport.SendKeys("Минск");

        }
    }
}
