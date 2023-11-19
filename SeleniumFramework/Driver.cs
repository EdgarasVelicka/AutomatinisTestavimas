using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        internal static ThreadLocal <IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void InitializeDriver()
        {
            driver.Value = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        //internal static void OpenPage(string url)
        //{
        //    driver.value.Url = url;
        //}

        public static string TakeScreenshot(string method)
        {
            string screenshotFolder = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            //string screenshotName1 = Guid.NewGuid().ToString();
            string screenshotName = $"{method}-{DateTime.Now.ToString("yyyy-MM-dd    (H-mm-ss)")}";
            string screenshotPath = $"{screenshotFolder}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotFolder);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotPath);
            return screenshotPath;
        }

        public static string GetPageTitle()
        {
            return driver.Value.Title;
        }

        public static void QuitDriver()
        {
            driver.Value.Quit();
        }
    }
}
