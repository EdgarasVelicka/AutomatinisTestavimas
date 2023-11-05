using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.Threading.Tasks;

namespace Uzduotis18_Testai
{
    public class DemoQA
    {
        [Test]
        public void IvestiInfo()
        {
            string expectedName = "Vardenis Pavardenis"; 
            string expectedEmail = "vardpavard@one.lt";
            string expectedCurrentAdress = "Kietaviškių km. 7, Elektrėnų sav.";
            string expectedPermanentAdress = "Šviesos g. 32-7, Elektrėnai";

            IWebDriver driver = new ChromeDriver ();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inpuFullName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            inpuFullName.SendKeys(expectedName);

            IWebElement inpuEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            inpuEmail.SendKeys(expectedEmail);

            IWebElement inputcurrentAdress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            inputcurrentAdress.SendKeys(expectedCurrentAdress);

            IWebElement inputpermanentAdress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            inputpermanentAdress.SendKeys(expectedPermanentAdress);

            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id=\"userForm\"]//button")); 
            buttonSubmit.Click();

            var outputFullName = driver.FindElement(By.XPath("//*[@id=\"name\"]"));
            string actualName = outputFullName.Text;

            var outputEmail= driver.FindElement(By.XPath("//*[@id=\"email\"]"));
            string actualEmail = outputEmail.Text;

            var outputCurrentAdress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            string actualCurrentAdress = outputCurrentAdress.Text;

            var outputPermanentAdress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            string actualPermanentAdress = outputPermanentAdress.Text;

            driver.Close();


            Assert.AreEqual(expectedName,actualName);
            Assert.AreEqual(expectedEmail,actualEmail);
            Assert.AreEqual(expectedCurrentAdress,actualCurrentAdress);
            Assert.AreEqual(expectedPermanentAdress,actualPermanentAdress);
        }
        [Test]
        public void InfoWithInvalidCredential()
        {
            string email = "vardpavard.one.lt";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inpuEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            inpuEmail.SendKeys(email);

            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id=\"userForm\"]//button"));
            buttonSubmit.Click();

            var expectedErrorMessage = "Error";
            var actualErrorMessage = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));

            driver.Close();

            Assert.Equals(expectedErrorMessage, actualErrorMessage);

        }
    }
}
