namespace SeleniumFramework.Pages.Bethesda
{
    public class BethesdaHomePage
    {
        public static void Open()
        {
            Common.OpenPage("https://bethesda.net");
        }
        public static void ClickChangeCookiePreferencesButton()
        {
            Common.ClickElement(Locators.BethesdaHome.ChangeCookiePreferencesButton);
        }

        public static void ClickConfirmCookieChoices()
        {
            Common.ClickElement(Locators.BethesdaHome.ConfirmCookieChoicesButton);
        }

        public static void ClickLogInSignUpButton()
        {
            Common.ClickElement(Locators.BethesdaHome.LogInSignUpButton);
        }

        public static void ClickSearchIcon()
        {
            Common.ClickElement(Locators.BethesdaHome.SearchIcon);
        }

        public static void EnterSearchText(string enterText)
        {
            Common.SendKeysToElement(Locators.BethesdaHome.SearchInput, enterText);
        }

        public static void ClickSearchButton()
        {
            Common.ClickElement(Locators.BethesdaHome.SearchButton);
        }

        public static void ClickSearchResultsInHelp()
        {
            Common.ClickElement(Locators.BethesdaHome.Help);
        }

        public static string ActualSearchResults()
        {
            return Common.GetElementText(Locators.BethesdaHome.SearchResultsInHelp);
        }

        public static void ClickMenuIcon()
        {
            Common.ClickElement(Locators.BethesdaHome.MenuIcon);
        }

        public static void ClickElderScrollsVIcon()
        {
            Common.ClickElement(Locators.BethesdaHome.ElderScrollsVIcon);
            SwitchWindowControl();
        }

        public static void SwitchWindowControl()
        {
            string currentHandle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromParentWindowByHandle(currentHandle);
        }
    }
}
