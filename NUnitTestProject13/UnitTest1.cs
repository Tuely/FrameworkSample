using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            driver.Navigate().GoToUrl("https://hugweb-g2itest.azurewebsites.net/quote/CarG2I");
            driver.Manage().Window.Maximize();

            SelectElement dropDownValue = new SelectElement(driver.FindElement(By.Id("title")));
            dropDownValue.SelectByText("Mr");

            //var email=driver.FindElement(By.Id("email")).GetAttribute("value");
           //var s= email.GetAttribute("value");
            driver.Close();
            driver.Quit();
            
        }
    }
}