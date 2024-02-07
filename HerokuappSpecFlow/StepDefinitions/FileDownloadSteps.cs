using HerokuappSpecFlow.Framework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Aquality.Selenium.Core.Utilities;
using HerokuappSpecFlow.Framework.Utils;

namespace HerokuappSpecFlow.StepDefinitions
{
    [Binding]
    internal class FileDownloadSteps
    {
        private FileDownloadPage fileDownloadPage = new();
        private string fileName;
        private string filePath;
        private static readonly JsonSettingsFile testdata = new("testdata.json");


        [When(@"I click the download link for the file ""([^""]*)""")]
        public void WhenIClickTheDownloadLinkForTheFile(string fileName)
        {
            fileName = testdata.GetValue<string>("fileDownload.fileName");
            filePath = testdata.GetValue<string>("fileDownload.folderPath") + fileName;
            Assert.IsTrue(fileDownloadPage.IsFileDownloadLinkDisplayed(fileName), "Download link is not displayed");
            fileDownloadPage.ClickFileDownloadLink(fileName);
        }


        [Then(@"the file ""(.*)"" should be downloaded successfully")]
        public void ThenTheFileShouldBeDownloadedSuccessfully(string fileName)
        {
            string fullFilePath = Path.GetFullPath(filePath);
            Assert.IsTrue(FileUtils.IsFileExists(fullFilePath), "File is not downloaded");
        }

        [AfterScenario]
        public void DeleteFile()
        {
            FileUtils.DeleteFileIfExists(new FileInfo(Path.GetFullPath(filePath)));
        }
    }
}
