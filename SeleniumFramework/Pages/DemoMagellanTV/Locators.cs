namespace SeleniumFramework.Pages.DemoMagellanTV
{
    internal class Locators
    {
        internal class MagellanTvLogin
        {
            internal static string LoginButton = "/html/body/header/div[1]/nav/a[3]";
            internal static string EnterEmail = "//*[@id=\"formBasicEmail\"]";
            internal static string EnterPassword = "//*[@id=\"formBasicPassword-Password\"]";
            internal static string SubmitButton = "//*[@id=\"__next\"]/div[2]/main/div/div/form/button";
            internal static string ErrorInvalidEmail = "//*[@id=\"__next\"]/div[2]/main/div/div/form/div[1]/p";
            internal static string CheckboxNotRobot = "//*[@id=\"recaptcha-anchor-label\"]";
            internal static string ErrorUserName = "//*[@id=\"__next\"]/div[2]/main/div/div/form/p[2]";
        }
    }
}
