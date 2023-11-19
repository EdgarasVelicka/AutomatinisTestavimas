using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoMagellanTV;

namespace SeleniumTests.Pages.MagellanTvTests
{
    
    internal class LoginTests : BaseTest
    {
        [Test]
        public void ConfirmThatErrorMessageAppearsByEnteringInvalidEmail()
        {
            string email = "invalid";
            string password = "Namai";
            string expectedErrorMessage = "Please enter a valid email address";
            
            MagellanTvLogin.Open();
            MagellanTvLogin.PushLoginButton();
            MagellanTvLogin.EnterEmail(email);
            MagellanTvLogin.EnterPassword(password);
            MagellanTvLogin.PressSubmitButton();
            
            Assert.That(MagellanTvLogin.GetErrorInvalidEmail(), Is.EqualTo (expectedErrorMessage));
        }

    }   
}
