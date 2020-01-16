using OpenQA.Selenium;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Common;

namespace UnitTestProject1.CoreUi
{
    /// <summary>
    /// Sample for angular 
    /// </summary>
    public class NgWebDriverSupport
    {
        [ThreadStatic] private static NgWebDriver _ngDriver;
        [ThreadStatic] private static IWebDriver _supportDriver;
        public static NgWebDriver NgWebDriver()
        {
            return _ngDriver;
        }
        public static IWebDriver LaunchDriver(string browserType)
        {
            _supportDriver = BrowserFactory.IntializeBrowser(AppConfigManager.GetBrowser());
            
            _ngDriver = NewNgDriver();

            return _supportDriver;
        }

        public static NgWebDriver NewNgDriver()
        {
            var newNgDriver = new NgWebDriver(_supportDriver);
            newNgDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            newNgDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            newNgDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            return newNgDriver;
        }

        public void AngularWait(int timeout = 30)
        {
            _ngDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(timeout);
            _ngDriver.WaitForAngular();
            _ngDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
        }

    }
}
