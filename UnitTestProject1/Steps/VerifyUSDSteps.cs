using System;
using TechTalk.SpecFlow;
using UnitTestProject1.Common;
using UnitTestProject1.Pages;

namespace UnitTestProject1
{
    [Binding]
    public class VerifyUSDSteps
    {
        private PageObjectFactory _page;
        public VerifyUSDSteps(PageObjectFactory page)
        {
            _page = page;
        }

        [Given(@"I navigate into url")]
        public void GivenINavigateIntoUrl()
        {
            BasePage.NavigateUrl(AppConfigManager.GetBaseUrl());
        }

        [Given(@"I search for '(.*)'")]
        public void GivenISearchFor(string gbpValue)
        {
            _page.homePage().Search(gbpValue);
        }

        [Then(@"I validate details")]
        public void ThenIValidateDetails()
        {
            _page.homePage().Validate();
        }
    }
}
