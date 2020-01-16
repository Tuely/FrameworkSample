using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.CoreUi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;


namespace UnitTestProject1.Pages
{
   public  class HomePage
    {
        protected WebDriverSupport _driverSupport = new WebDriverSupport();


        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement SearchBox { get; set; }


        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='knowledge-currency__updatable-data-column']/div[3]/table/tbody/tr/td/input")]
        private IWebElement firstValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='knowledge-currency__updatable-data-column']/div[3]/table/tbody/tr[3]/td/input")]
        private IWebElement secondValue { get; set; }

        #region SearchActions
        public void Search(string gbpValue)
        {
            _driverSupport.EnterText(SearchBox, gbpValue);
            SearchButton.Click();
        }
        public void EnterSearchValue(string svalue)
        {
            _driverSupport.EnterText(SearchBox, svalue);
        }
        #endregion
        #region ValidateActions
        public void Validate()
        {
            Assert.AreEqual("1", firstValue.GetAttribute("value"));
            var usdValue = Convert.ToDouble(secondValue.GetAttribute("value"));
            Assert.Greater(usdValue, 0.0);
        }
        #endregion

    }
}
