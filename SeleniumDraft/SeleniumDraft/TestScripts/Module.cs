using NUnit.Framework;
using SeleniumDraft.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDraft.TestScripts
{
    [TestFixture]
    public class Module : BaseClass.Base
    {
        [Test]
        public void Test()
        {
            var mainPage = new MainPage(driver, wait);
            var articlePage = mainPage.NavigateToArticle();
            articlePage.VerifyArticle();
            
            
        }
    }
}
