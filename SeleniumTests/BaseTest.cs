﻿using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumFramework;

namespace SeleniumTests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
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
