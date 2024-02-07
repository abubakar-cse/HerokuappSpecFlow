using HerokuappSpecFlow.Framework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HerokuappSpecFlow.StepDefinitions
{
    [Binding]
    internal class DynamicControlsSteps
    {
        private DynamicControlPage dynamicControlPage = new();
        private static readonly string randomString = Guid.NewGuid().ToString();

        [When(@"I click the '([^']*)' on the Dynamic Controls Page")]
        public void WhenIClickTheOnTheDynamicControlsPage(string enable)
        {
            dynamicControlPage.ClickEnableBtn();
        }
        [When(@"I input random texts")]
        public void WhenIInputRandomTexts()
        {
            dynamicControlPage.InputText(randomString);
        }
        [Then(@"display the entered random texts")]
        public void ThenDisplayTheEnteredRandomTexts()
        {
            Assert.AreEqual(randomString, dynamicControlPage.GetInputTextValue(), "Text is not Displayed");
        }
    }
}
