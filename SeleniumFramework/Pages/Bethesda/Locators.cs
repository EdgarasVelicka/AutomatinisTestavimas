namespace SeleniumFramework.Pages.Bethesda
{
    internal class Locators
    {
        internal class BethesdaHome
        {
            internal static string ChangeCookiePreferencesButton = "//*[@id='onetrust-pc-btn-handler']";
            internal static string ConfirmCookieChoicesButton = "(//*[@tabindex='0'])[28]";
            //*[@id=\"onetrust-pc-sdk\"]/div/div[3]/div[1]/button
            internal static string LogInSignUpButton = "(//*[@aria-haspopup='dialog'])[2]";
            //*[@id=\"globalNavBar\"]/header/div/div[2]/div[2]/button[1]
            internal static string SearchIcon = "//*[@href='/en/search']";
            //*[@id=\"globalNavBar\"]/header/div/div[2]/div[1]/a
            internal static string SearchInput = "//*[@id=\"search-input\"]";
            internal static string SearchButton = "(//*[@role='button'])[1]";
            //*[@id=\"globalNavBar\"]/div/form/div/span[2]/div
            internal static string Help = "(//*[@role='button'])[5]";
            //*[@id=\"_bnContent\"]/div/aside/div/div[1]/div[4]/div[2]
            internal static string SearchResultsInHelp = "//*[@id=\"_bnContent\"]//header";
            //*[@id=\"_bnContent\"]/div/section/div/div/div[1]/header/h3
            internal static string MenuIcon = "//*[@id=\"global-hamburger-menu\"]";
            internal static string ElderScrollsVIcon = "(//*[@target='_blank'])[25]";
            //*[@id=\"global-menubar-drawer\"]/div[3]/div/div/div[3]/div[1]/div[1]/ul/li[11]/a
        }

        internal class LoginSignUp
        {
            internal static string SignUpButton = "//*[@id=\"createAccountBtn\"]";
            internal static string SelectCountry = "//*[@id=\"country-field\"]";
            internal static string ClearCountryInput = "//*[@class='MuiAutocomplete-endAdornment']";
            ///html/body/div[3]/div[3]/div/div/form/div[1]/div/div[2]/div/div/div/div/div
            internal static string CreateAccountButton = "//*[@id=\"signupBtn\"]/span";
            internal static string EnterEmail = "//*[@id=\"optin-email-field\"]";
            internal static string ButtonContinue = "(//*[@class='MuiButton-label'])[5]";
            //*html/body/div[3]/div[3]/div/div[2]/form/div[3]/div/button[2]/span*/
            internal static string InputBorderColor = "//*[@formname='joinForm']/div";
            ///html/body/div[3]/div[3]/div/div[2]/form/div[1]/div/div/div/div/div
            internal static string UserName = "//*[@id=\"username-input\"]";
            internal static string Password = "//*[@id=\"password-input\"]";
            internal static string LoginButton = "//*[@id=\"submitLoginBtn\"]";
            internal static string ErrorMessage = "(//*[@role='status'])[2]";
            ///html/body/div[3]/div[3]/div/div[2]/p
            internal static string UsernameVisible = " //*[@class='jss62']";
            //*[@id=\"globalNavBar\"]/header/div/div[2]/div[2]/button/div
        }
    }
}
