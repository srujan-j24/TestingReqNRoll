using System;
using Reqnroll;
using ReqnrollProject.Pages;

namespace ReqnrollProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage lp;

        public LoginStepDefinitions(DriverContext context)
        {
            lp = new LoginPage(context.Driver);
        }


        [Given("User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            lp.launchBrowser();
        }

        [When("User enters the username {string} and password {string}")]
        public void WhenUserEntersTheUsernameAndPassword(string admin, string p1)
        {
            lp.enterUsernameAndPassword(admin, p1);
        }

        [When("User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            lp.submit();
        }

        [Then("User is navigated to Home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            lp.homePageDispalyed();
        }

        [Then("User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(DataTable dataTable)
        {
            Console.WriteLine("Done");
        }

    }
}
