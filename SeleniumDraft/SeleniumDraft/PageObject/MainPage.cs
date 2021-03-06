using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq.Expressions;

namespace SeleniumDraft.PageObject
{
    public class MainPage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public MainPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How=How.XPath, Using = "//h5[contains(text(),'Biogel No Limits Grey 25 kg')]")]
        public IWebElement Article { get; set; }

        public Article NavigateToArticle()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText(Article.Text)));
            Article.Click();
            return new Article(driver, wait);
        }
    }
}
