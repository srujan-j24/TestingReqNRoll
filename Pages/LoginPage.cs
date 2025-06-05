using OpenQA.Selenium;

namespace ReqnrollProject.Pages
{
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


        public void launchBrowser()
        {
            _driver.Navigate().GoToUrl(Config.Baseurl + "/web/index.php/auth/login");
            Thread.Sleep(5000);
        }
        
        public void enterUsernameAndPassword(string username, string password)
        {
            _driver.FindElement(usernameField).SendKeys(username);
            _driver.FindElement(passwordField).SendKeys(password);
        }

        public void submit()
        {
            _driver.FindElement(loginFromLocator).Click();
        }

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
