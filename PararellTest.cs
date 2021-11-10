using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using GoogleTest.Pages;

namespace GoogleTest
{

    public class ParallelTest : Base
    {
        private static string title = "Facebook - Log In Or Sign Up";
        private readonly GoogleHomePage googleHomePage;
        
        public ParallelTest(string browserName) : base(browserName)
        {
            googleHomePage = new(driver);
            driver.Manage().Window.Maximize();
        }

        [Test, Category("google_search")]
        public void SearchGoogle()
        {    
            googleHomePage.Open();
            googleHomePage.Search("Facebook");
            Assert.AreEqual(googleHomePage.GetLinkTitle(), title);
            
        }
    }
}
