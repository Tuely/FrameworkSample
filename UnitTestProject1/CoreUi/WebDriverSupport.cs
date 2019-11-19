using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProject1.Common;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.CoreUi
{
  public class WebDriverSupport
    {
        private static IWebDriver _driver;

        public static IWebDriver SupportDriver()
        {
            return _driver;
        }

        public static void DisposeDriver()
        {
            _driver.Dispose();
            _driver.Quit();
            _driver.Close();
        }

        public static IWebDriver LaunchDriver()
        {
            _driver = BrowserFactory.IntializeBrowser(AppConfigManager.GetBrowser());
                return _driver;
        }


        public void EnterText(IWebElement e,string text)
        {
            e.Clear();
            e.SendKeys(text);
        }

        public void SelectValueDropDown(IWebElement e, string test)
        {
            var select = new SelectElement(e);
            select.SelectByText(test);
        }
    }
}
