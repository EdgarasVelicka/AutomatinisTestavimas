﻿using NUnit.Framework;
using SeleniumFramework.Pages.Bethesda;

namespace SeleniumTests.Pages.BethesdaTests
{
    internal class LoginSignUpFormTests : BaseTestForBetheda
    {

        [Test, Order(1)]

        public static void EmailInputTurnsReedEnteringInvalidEmail()
        {
            string email = "email";
            string emailInputBorderColor = "1.6px solid rgb(235, 61, 26)";
            string country = "Lithuania";

            BethesdaHomePage.ClickLogInSignUpButton();
            LoginSignUpForm.ClickSignUpButton();
            LoginSignUpForm.ClearCountryInput();
            LoginSignUpForm.SelectCountry(country);
            LoginSignUpForm.ClickCreateAccountButton();
            LoginSignUpForm.EnterEmail(email);
            LoginSignUpForm.ClickButtonContinue();

            Assert.That(LoginSignUpForm.EmailInputBorderColor(), Is.EqualTo(emailInputBorderColor));
        }

        [Test, Order(2)]

        public static void LoginWithInvalidCredentials()
        {
            string username = "example";
            string password = "password";
            string expectedErrorMessage = "Incorrect username or password. Please try again.";

            BethesdaHomePage.ClickLogInSignUpButton();
            LoginSignUpForm.EnterUserName(username);
            LoginSignUpForm.EnterPassword(password);
            LoginSignUpForm.ClickLoginButton();

            Assert.That(LoginSignUpForm.ErrorMessageText(), Is.EqualTo(expectedErrorMessage));
        }

        [Test, Order(3)]

        public static void LoginWithValidCredentials()
        {
            string username = TestContext.Parameters.Get("bethesdaUsername");
            string password = TestContext.Parameters.Get("bethesdaPassword");

            BethesdaHomePage.ClickLogInSignUpButton();
            LoginSignUpForm.EnterUserName(username);
            LoginSignUpForm.EnterPassword(password);
            LoginSignUpForm.ClickLoginButton();

            Assert.That(LoginSignUpForm.VisibleUsername(), Is.EqualTo(username));
        }
    }
}
