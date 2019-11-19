using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnitTestProject1.CoreUi;
using UnitTestProject1.Common;
namespace UnitTestProject1.Pages
{
   public class BasePage
    {
        private IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public Tpage GetPage<Tpage>(IWebDriver driver) where Tpage : new()
        {
            if(_driver==null)
            { _driver = driver; }

            var pageInstance = new Tpage();
            PageFactory.InitElements(driver, pageInstance);
            return pageInstance;

        }

        public static void NavigateUrl(string url)
        {
            WebDriverSupport.SupportDriver().Navigate().GoToUrl(AppConfigManager.GetBaseUrl());
        }
    }
}
