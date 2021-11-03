using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace GoogleTest
{
    [TestFixture("Chrome")]
    [TestFixture("FireFox")]
    [TestFixture("IE")]
    [Parallelizable]
    public class Base                      //* settings > svaki save visual studio identaciju
    {
        public IWebDriver driver;
        protected WebDriverWait wait;
        public Base(string browserName)   
        {
            if(browserName.Equals("Chrome"))
                driver = new ChromeDriver();
            else if(browserName.Equals("FireFox"))
                driver = new FirefoxDriver();
            else 
                driver = new InternetExplorerDriver();
            wait = new WebDriverWait(driver, new System.TimeSpan(0,0,10));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
