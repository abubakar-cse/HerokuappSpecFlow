using TechTalk.SpecFlow;
using HerokuappSpecFlow.Framework.Pages;

namespace HerokuappSpecFlow.Framework.StepDefinitions
{
    [Binding]
    internal class MainPageSteps
    {
        MainPage mainPage = new();

        [Given(@"I got to '(.*)' on the Main Page")]
        public void GivenIGotToOnTheMainPage(string link)
        {
            mainPage.ClickNavigationLink(link);
        }
    }
}
