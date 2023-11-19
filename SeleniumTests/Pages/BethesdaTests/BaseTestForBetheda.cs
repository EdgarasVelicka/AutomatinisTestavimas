using NUnit.Framework.Interfaces;
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.Bethesda;

namespace SeleniumTests.Pages.BethesdaTests
{
    internal class BaseTestForBetheda
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            BethesdaHomePage.Open();
            BethesdaHomePage.ClickChangeCookiePreferencesButton();
            BethesdaHomePage.ClickConfirmCookieChoices();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string method = TestContext.CurrentContext.Test.MethodName;
                string screenshotPathPath = Driver.TakeScreenshot(method);
                TestContext.AddTestAttachment(screenshotPathPath);
            }

            Driver.QuitDriver();
        }
    }
}
