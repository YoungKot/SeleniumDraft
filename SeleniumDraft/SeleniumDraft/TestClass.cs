// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumDraft
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            //var answer = 42;
            //Assert.That(answer, Is.EqualTo(42), "Some useful error message");
            Assert.Ignore("Bugs 124");
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "http://www.geokoll.lv/lv";
                Thread.Sleep(2000);
                driver.Quit();
            }
            catch(Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\temp\\SeleniumPics\\file1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
            }
            

        }
    }
}
