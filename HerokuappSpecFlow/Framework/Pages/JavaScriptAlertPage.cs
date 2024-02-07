using System;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace HerokuappSpecFlow.Framework.Pages
{
	internal class JavaScriptAlertPage : Form
	{
		private const string PageName = "JavaScript Alerts";
		private IButton clickForJSConfirmButton => ElementFactory.GetButton(By.XPath("//button[@onclick = 'jsConfirm()']"), "Click for JS Alert Button");
        private ILabel okMessage => ElementFactory.GetLabel(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, "You clicked: Ok")), "Successfull Message");

        public JavaScriptAlertPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
		{
		}

		public void ClickJSConfirmtButton() => clickForJSConfirmButton.Click();
		public bool IsOkMessageDisplayed() => okMessage.State.IsDisplayed;
	}
}