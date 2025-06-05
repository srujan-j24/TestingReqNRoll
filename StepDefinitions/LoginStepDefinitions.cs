using System;
using Reqnroll;
using ReqnrollProject.Pages;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;
using NUnit.Framework;
using OpenQA.Selenium;
using Allure.NUnit;

namespace ReqnrollProject.StepDefinitions
{
    [Binding]
    [AllureNUnit]
    [AllureSuite("Login Feature")]
    public class LoginStepDefinitions
    {
        private readonly LoginPage lp;

        public LoginStepDefinitions(DriverContext context)
        {
            lp = new LoginPage(context.Driver);
        }


        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [Given("User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            lp.launchBrowser();
        }

        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [When("User enters the username {string} and password {string}")]
        public void WhenUserEntersTheUsernameAndPassword(string admin, string p1)
        {
            lp.enterUsernameAndPassword(admin, p1);
        }

        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [When("User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            lp.submit();
        }

        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [Then("User is navigated to Home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            lp.homePageDispalyed();
        }

        [AllureSeverity(SeverityLevel.normal)]
        [AllureSuite("Login Feature")]
        [Then("User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(DataTable dataTable)
        {
            Console.WriteLine("Done");
        }

    }
}
