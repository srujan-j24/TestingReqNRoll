
using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V135.DOM;

namespace ReqnrollProject.Pages
{
    [AllureNUnit]
    [AllureSuite("Login Feature")]
    internal class LoginPage
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        By usernameField = By.XPath("//input[@name='username']");
        By passwordField = By.XPath("//input[@name='password']");
        By loginFromLocator = By.XPath("//button[@type='submit']");
        By homepagedisplayed = By.XPath("(//a[@class='oxd-main-menu-item'])[1]");


        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        public void launchBrowser()
        {
            _driver.Navigate().GoToUrl(Config.Baseurl + "/web/index.php/auth/login");
            Thread.Sleep(5000);
        }
        
        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        public void enterUsernameAndPassword(string username, string password)
        {
            _driver.FindElement(usernameField).SendKeys(username);
            _driver.FindElement(passwordField).SendKeys(password);
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        public void submit()
        {
            _driver.FindElement(loginFromLocator).Click();
        }

        [Test]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        public void homePageDispalyed()
        {
            Thread.Sleep(4000);
            IWebElement homepage = _driver.FindElement(homepagedisplayed);
            if(homepage.Displayed)
            {
                Console.WriteLine("Home page is displayed");
            }
            else
            {
                Console.WriteLine("Home page is not displayed");
            }
        }
    }
}
