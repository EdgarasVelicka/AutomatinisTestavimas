using NUnit.Framework;
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

        //[TearDown]
        //public void TearDown()
        //{
        //    Driver.QuitDriver();
        //}
    }
}
