using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using BoDi;
using UnitTestProject1.Common;
using UnitTestProject1.CoreUi;

namespace UnitTestProject1
{
    [Binding]
    public sealed class Hooks1 :IDisposable
    {
        private static IWebDriver _currentDriver;
        private static IObjectContainer _iObjectContainer;

        public Hooks1(IObjectContainer objectContainer)
        {
            _iObjectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {

            _currentDriver = WebDriverSupport.LaunchDriver();
            _iObjectContainer.RegisterInstanceAs<IWebDriver>(_currentDriver);

        }

        public void Dispose()
        {
            _currentDriver?.Dispose();
            
        }
        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
