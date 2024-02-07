using System;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace HerokuappSpecFlow.Framework.Pages
{
	public class FileDownloadPage : Form
	{
        private const string PageName = "File Download";

        private IButton downloadLink(string fileName) => ElementFactory.GetButton(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, fileName)),
            $"Element name for (fileName");

        public FileDownloadPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public void ClickFileDownloadLink(string fileName) => downloadLink(fileName).Click();

        public bool IsFileDownloadLinkDisplayed(string fileName) => downloadLink(fileName).State.WaitForDisplayed();
    }
}

