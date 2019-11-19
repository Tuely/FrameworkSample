using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.CoreUi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnitTestProject1.DataEntites;

namespace UnitTestProject1.Pages
{
    public class RegistrationPage
    {
        protected static WebDriverSupport _driverSupport = new WebDriverSupport();

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign up')]")]
        private IWebElement SignUpButton { get; set; }

        [FindsBy(How = How.Id, Using = "title")]
        private IWebElement TitleElement { get; set; }

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement FirstName { get; set; }


        public void EnterTitle(string title)
        {
            _driverSupport.SelectValueDropDown(TitleElement, title);
        }

        public void EnterName(string fname)
        {
            _driverSupport.EnterText(FirstName, fname);
        }
        public void FillSignUpDetails(AccountDetails accountDetails)
        {
            SignUpButton.Click();
            EnterTitle(accountDetails.Title);
            EnterName(accountDetails.FirstName);

        }


    }
}
