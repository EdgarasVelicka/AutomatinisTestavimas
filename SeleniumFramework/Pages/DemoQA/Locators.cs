namespace SeleniumFramework.Pages.DemoQA
{
    internal class Locators
    {
        internal class TextBox
        {
            internal static string EnterFullName = "//*[@id='userName']";
            internal static string EnterEmail = "//*[@id='userEmail']";
            internal static string EnterCurrentAddress = "//*[@id='currentAddress']";
            internal static string EnterPermanentAddress = "//*[@id='permanentAddress']";
            internal static string ButtonSubmit = "//*[@id='submit']";
            internal static string PrintedFullName = "//*[@id='output']//*[@id='name']";
            internal static string PrintedEmail = "//*[@id='output']//*[@id='email']";
            internal static string PrintedCurrentAddress = "//*[@id='output']//*[@id='currentAddress']";
            internal static string PrintedPermanentAddress = "//*[@id='output']//*[@id='permanentAddress']";
        }
    }
}
