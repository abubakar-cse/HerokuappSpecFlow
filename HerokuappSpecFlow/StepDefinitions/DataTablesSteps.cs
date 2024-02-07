using HerokuappSpecFlow.Framework.Pages;
using NUnit.Framework;
using HerokuappSpecFlow.Framework.Utils;
using TechTalk.SpecFlow;

namespace HerokuappSpecFlow.StepDefinitions
{
    [Binding]
    internal class DataTablesSteps
    {
        private DataTablesPage dataTablesPage = new();

        [Then(@"Sum of the Due columns is (.*)")]
        public void ThenSumOfTheDueColumnsIs(double sum)
        {
            var actualSum = 0.00;
            foreach (string due in dataTablesPage.GetFirstDueList())
            {
                actualSum += StringUtils.GetDoubleFromString(due);
            }
            Assert.AreEqual(sum, actualSum, "Sum is not correct");
        }
    }
}
