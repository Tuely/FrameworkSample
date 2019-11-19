using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.CoreUi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UnitTestProject1.Pages
{
   public  class HomePage
    {
        protected WebDriverSupport _driverSupport = new WebDriverSupport();

        [FindsBy(How =How.XPath,Using = "//a[text() = 'LOG IN']")]
        private IWebElement LoginButton { get; set; }

        #region LoginActions
        public void Login()
        {
            LoginButton.Click();
        }
        #endregion

    }
}
