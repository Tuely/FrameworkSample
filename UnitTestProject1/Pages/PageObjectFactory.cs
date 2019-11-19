using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject1.Pages
{
  public  class PageObjectFactory
    {
        public IWebDriver _driver;
        public BasePage _basePage;
        public PageObjectFactory(IWebDriver driver, BasePage basePage)
        {
            _driver = driver;
            _basePage = basePage;
        }
        public HomePage homePage()
        {
            return _basePage.GetPage<HomePage>(_driver);
        }

        public RegistrationPage RegistrationPage()
        {
            return _basePage.GetPage<RegistrationPage>(_driver);
        }
    }
}
