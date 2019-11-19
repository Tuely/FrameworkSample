using System;
using TechTalk.SpecFlow;
using UnitTestProject1.Pages;
using UnitTestProject1.Common;
using TechTalk.SpecFlow.Assist;
using UnitTestProject1.DataEntites;

namespace UnitTestProject1
{
    [Binding]
    public class LoginSteps
    {
        private PageObjectFactory _page;
        public LoginSteps(PageObjectFactory page)
        {
            _page = page;
        }
        [Given(@"I navigate into url")]
        public void GivenINavigateIntoUrl()
        {
            BasePage.NavigateUrl(AppConfigManager.GetBaseUrl());
        }
        
        [Given(@"click login button")]
        public void GivenClickLoginButton()
        {
            _page.homePage().Login();
         
        }
        [Given(@"I enter signup information details")]
        public void GivenIEnterSignupInformationDetails(Table table)
        {
            var accountDetails = table.CreateInstance<AccountDetails>();
            _page.RegistrationPage().FillSignUpDetails(accountDetails);
        }


    }
}
