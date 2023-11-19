using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBox
    {   
        public static void Open()
        {
            Common.OpenPage("https://demoqa.com/text-box");
        }

        public static void EnterFullName(string fullName)
        {
            Common.SendKeysToElement(Locators.TextBox.EnterFullName, fullName);
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeysToElement(Locators.TextBox.EnterEmail, email);
        }

        public static void EnterCurrentAddress(string currentAddress)
        {
            Common.SendKeysToElement(Locators.TextBox.EnterCurrentAddress, currentAddress);
        }

        public static void EnterPermanentAddress(string permanentAddress)
        {
            Common.SendKeysToElement(Locators.TextBox.EnterPermanentAddress, permanentAddress);
        }

        public static void ClickButtonSubmit()
        {
            string script = "arguments[0].scrollIntoView(true);";
            Common.ExecuteJavascript(script, Locators.TextBox.ButtonSubmit);
            Common.ClickElement(Locators.TextBox.ButtonSubmit);
        }

        public static string GetOutputFullName()
        {
            return Common.GetElementText(Locators.TextBox.PrintedFullName);
        }

        public static string GetOutputEmail()
        {
            return Common.GetElementText(Locators.TextBox.PrintedEmail);
        }

        public static string GetOutputCurrentAddress()
        {
            return Common.GetElementText(Locators.TextBox.PrintedCurrentAddress);
        }

        public static string GetOutputPermanentAddress()
        {
            return Common.GetElementText(Locators.TextBox.PrintedPermanentAddress);
        }
        public static string GetEmailInputBorderColor()
        {
            System.Threading.Thread.Sleep(150);
            return Common.GetElementCssPropertyValue(Locators.TextBox.EnterEmail, "border-color");
        }

        public static string GetEmailInputClassValue()
        {
            return Common.GetElementHtmlAttributeValue(Locators.TextBox.EnterEmail, "class");
        }

        public static bool EmailOutputExists()
        {
            return Common.ElementExists(Locators.TextBox.PrintedEmail);
        }
    }
}
