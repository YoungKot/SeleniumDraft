using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDraft.BaseClass
{
    public class Base
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.geokoll.lv/lv";

        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
