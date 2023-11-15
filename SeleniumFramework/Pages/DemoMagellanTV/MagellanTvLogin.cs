namespace SeleniumFramework.Pages.DemoMagellanTV
{
    public class MagellanTvLogin
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.magellantv.com");
        }

        public static void PushLoginButton()
        {
            Common.ClickElement(Locators.MagellanTvLogin.LoginButton);
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeysToElement(Locators.MagellanTvLogin.EnterEmail, email); 
        }

        public static void EnterPassword(string password)
        {
            Common.SendKeysToElement(Locators.MagellanTvLogin.EnterPassword, password);
        }

        public static void PressSubmitButton()
        {
            Common.ClickElement(Locators.MagellanTvLogin.SubmitButton);
        }

        public static string GetErrorInvalidEmail()
        {
            return Common.GetElementText(Locators.MagellanTvLogin.ErrorInvalidEmail);
        }
        
        public static string GetErrorUserName()
        {
            return Common.GetElementText(Locators.MagellanTvLogin.ErrorUserName);
        }
    }
}
