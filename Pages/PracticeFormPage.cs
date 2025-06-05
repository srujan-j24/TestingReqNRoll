using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ReqnrollProject.Pages
{
    public class PracticeFormPage
    {
        private readonly IWebDriver _driver;

        public PracticeFormPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToFormPage()
        {
            _driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");
            Thread.Sleep(4000);
        }

        public void EnterName(string name) =>
            _driver.FindElement(By.XPath("//input[@id='name']")).SendKeys(name);

        public void EnterEmail(string email) =>
            _driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(email);

        public void SelectGender(string gender)
        {
            if (gender == "male")
                _driver.FindElement(By.XPath("//input[@id='gender']")).Click();
            else if (gender == "female")
                _driver.FindElement(By.XPath("//div[3]//div[1]//div[1]//div[2]//input[1]")).Click();
            else
                _driver.FindElement(By.XPath("//div[3]//div[1]//div[1]//div[3]//input[1]")).Click();
        }

        public void EnterMobileNumber(string mobile) =>
            _driver.FindElement(By.XPath("//input[@id='mobile']")).SendKeys(mobile);

        public void EnterDateOfBirth(string dob)
        {
            var input = _driver.FindElement(By.XPath("//input[@id='dob']"));
            input.Clear();
            input.SendKeys(dob);
        }

        public void EnterSubject(string subject) =>
            _driver.FindElement(By.XPath("//input[@id='subjects']")).SendKeys(subject);

        public void SelectHobby(string hobby)
        {
            if (hobby == "Sports")
                _driver.FindElement(By.XPath("//input[@id='hobbies']")).Click();
            else if (hobby == "Reading")
                _driver.FindElement(By.XPath("//div[7]//div[1]//div[1]//div[2]//input[1]")).Click();
            else if (hobby == "Music")
                _driver.FindElement(By.XPath("//div[7]//div[1]//div[1]//div[3]//input[1]")).Click();
        }

        public void EnterCurrentAddress(string address) =>
            _driver.FindElement(By.XPath("//textarea[@id='picture']")).Click(); // Possibly incorrect XPath, check this

        public void SelectState(string state)
        {
            var dropdown = new SelectElement(_driver.FindElement(By.XPath("//select[@id='state']")));
            dropdown.SelectByText(state);
        }

        public void SelectCity(string city)
        {
            var dropdown = new SelectElement(_driver.FindElement(By.XPath("//select[@id='city']")));
            dropdown.SelectByText(city);
        }

        public void ClickSubmit() =>
            _driver.FindElement(By.XPath("//input[@value='Login']")).Click();

        public void ConfirmSubmission() =>
            Console.WriteLine("Submitted");
    }
}
