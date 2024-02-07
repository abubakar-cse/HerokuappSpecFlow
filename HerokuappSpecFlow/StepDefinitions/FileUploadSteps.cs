using HerokuappSpecFlow.Framework.Pages;
using HerokuappSpecFlow.Framework.Utils;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Aquality.Selenium.Core.Utilities;

namespace HerokuappSpecFlow.StepDefinitions
{
    [Binding]
    internal class FileUploadSteps
    {
        private FileUploadPage fileUploadPage = new();
        private static readonly JsonSettingsFile testdata = new("testdata.json");
        private static string fileName;
        private static string filePath;

        [When(@"I upload the file")]
        public void WhenIUploadTheFile()
        {
            fileName = testdata.GetValue<string>("fileUpload.fileName");
            filePath = testdata.GetValue<string>("fileUpload.folderPath") + fileName;

            fileUploadPage.UploadFileToChooseFileTextBox(FileUtils.GetAbsoluateFilePath(filePath));
            fileUploadPage.ClickFileUploadBtn();
        }


        [Then(@"the uploaded file should have the correct name")]
        public void ThenTheUploadedFileShouldHaveTheCorrectName()
        {
            Assert.AreEqual(fileUploadPage.GetNameOfUploadedFile(), fileName, "File is not correct or the name is different");
        }
    }
}
