using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDraft.PageObject
{
    public class Article
    {
        IWebDriver driver;
        WebDriverWait wait;

        public Article(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Biogel No Limits Grey 25 kg')]")]
        public IWebElement Heading { get; set; }

        public void VerifyArticle()
        {
            var title = "Biogel No Limits Grey 25 kg";
            Assert.That(title, Is.EqualTo(Heading.Text));
        }
    }
}
