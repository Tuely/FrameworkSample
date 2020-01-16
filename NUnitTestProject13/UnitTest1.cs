using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject13
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(" http://slowwly.robertomurray.co.uk/delay/3000/url/http://www.google.co.uk");
            driver.FindElement(By.Name("q")).SendKeys("GBP TO USD");
            driver.FindElement(By.Name("btnK")).Click();
            string s = driver.FindElement(By.XPath("//div[@id='knowledge-currency__updatable-data-column']/div[3]/table/tbody/tr/td/input")).GetAttribute("value");
            Assert.AreEqual("1", s);
            var ss = driver.FindElement(By.XPath("//div[@id='knowledge-currency__updatable-data-column']/div[3]/table/tbody/tr[3]/td/input")).GetAttribute("value");
            var sss = Convert.ToDouble(ss);
            Assert.Greater(sss, 0.0);

        }
    }
}