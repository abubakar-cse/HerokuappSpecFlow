using NUnit.Framework;
using TechTalk.SpecFlow;
using HerokuappSpecFlow.Framework.Pages;
using Aquality.Selenium.Browsers;

namespace HerokuappSpecFlow.Framework.StepDefinitions
{
    [Binding]
    internal class JavScriptAlertPageSteps
    {
        private JavaScriptAlertPage jsAlertPage = new();

        [When(@"I generate JS alert on the JavaScript Alerts Page")]
        public void WhenIGenerateJSAlertOnTheJavaScriptAlertsPage()
        {
            jsAlertPage.ClickJSConfirmtButton();
        }
        [When(@"I accept the alert")]
        public void WhenIAcceptTheAlert()
        {
            AqualityServices.Browser.HandleAlert(AlertAction.Accept);
        }
        [Then(@"Ok message is displayed on JavaScript Alerts Page")]
        public void ThenOkMessageIsDisplayedOnJavaScriptAlertsPage()
        {
            Assert.IsTrue(jsAlertPage.IsOkMessageDisplayed(), "Ok message is not Displayed");
        }
    }
}
