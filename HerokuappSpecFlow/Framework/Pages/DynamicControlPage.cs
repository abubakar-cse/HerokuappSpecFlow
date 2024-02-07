using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace HerokuappSpecFlow.Framework.Pages
{
    internal class DynamicControlPage : Form
    {
        private const string PageName = "Dynamic Controls";

        private IButton enableBtn = ElementFactory.GetButton(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, "Enable")),
            "Enable Button");
        private ITextBox inputField = ElementFactory.GetTextBox(By.XPath("//*[@id='input-example']//input"),
            "Input Element");
        private static readonly string randomString = Guid.NewGuid().ToString();

        public DynamicControlPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName) { }

        public void ClickEnableBtn() => enableBtn.Click();

        public bool IsInputEnabled() => inputField.State.WaitForEnabled();

        //public void InputText(string text) => inputField.ClearAndType(text);
        public void InputText(string randomString)
        {
            inputField.State.WaitForEnabled();
            inputField.Type(randomString);
        }

        public string GetInputTextValue() => inputField.Value;
    }
}
