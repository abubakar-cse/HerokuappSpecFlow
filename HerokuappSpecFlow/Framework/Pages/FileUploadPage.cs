using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace HerokuappSpecFlow.Framework.Pages
{
    internal class FileUploadPage : Form
    {
        private const string PageName = "File DOwnload";

        private readonly ITextBox chooseFileTextBox = ElementFactory.GetTextBox(By.Id("file-upload"), "Choose file Button");
        private readonly IButton fileUploadBtn = ElementFactory.GetButton(By.Id("file-submit"), "File submit Button");
        private readonly ILabel fileUploadedField = ElementFactory.GetLabel(By.Id("uploaded-files"), "File uploaded Field");

        public FileUploadPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName) { }

        public void UploadFileToChooseFileTextBox(string value) => chooseFileTextBox.SendKeys(value);
        public void ClickFileUploadBtn() => fileUploadBtn.Click();
        public string GetNameOfUploadedFile() => fileUploadedField.Text;
    }
}
