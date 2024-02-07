using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using HerokuappSpecFlow.Framework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HerokuappSpecFlow.StepDefinitions
{
    [Binding]
    internal class BasicAuthSteps
    {
        private BasicAuthPage basicAuthPage = new();
        private readonly Browser browser = AqualityServices.Browser;
        private static readonly JsonSettingsFile testdata = new("testdata.json");

        [SetUp]
        [When(@"I input '([^']*)' as username and '([^']*)' password on the LogIn Page")]
        public void WhenIInputAsUsernameAndPasswordOnTheLogInPage(string admin, string admin1)
        {
            browser.RegisterBasicAuthenticationAndStartMonitoring(
                "the-internet.herokuapp.com",
                testdata.GetValue<string>("basicAuth.login"),
                testdata.GetValue<string>("basicAuth.password")
                );
        }


        [Then(@"Success message displayed on the BasicAuth Page")]
        public void ThenSuccessMessageDisplayedOnTheBasicAuthPage()
        {
            Assert.IsTrue(basicAuthPage.IsSuccessMessageDisplayed(), "Success message is not Displayed");
        }
    }
}
