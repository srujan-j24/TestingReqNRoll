using System;
using OpenQA.Selenium;
using Reqnroll;
using ReqnrollProject.Pages;

namespace ReqnrollProject.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private readonly PracticeFormPage _formPage;

        public Feature1StepDefinitions(DriverContext context)
        {
            _formPage = new PracticeFormPage(context.Driver);
        }

        [Given("I navigate to the Selenium practice form page")]
        public void GivenINavigateToTheSeleniumPracticeFormPage()
        {
            Log.Info("opeining browser");
            _formPage.NavigateToFormPage();
        }

        [When("I enter {string} as Name")]
        public void WhenIEnterAsName(string name)
        {
            Log.Info("Entering name");
            _formPage.EnterName(name);
        }

        [When("I enter {string} as Email")]
        public void WhenIEnterAsEmail(string email)
        {
            Log.Info("Entering email");
            _formPage.EnterEmail(email);
        }

        [When("I select {string} as Gender")]
        public void WhenISelectAsGender(string gender)
        {
            Log.Info("Selecting gender");
            _formPage.SelectGender(gender);
        }

        [When("I enter {string} as Mobile Number")]
        public void WhenIEnterAsMobileNumber(string mobile)
        {
            Log.Info("Entering mobile number");
            _formPage.EnterMobileNumber(mobile);
        }

        [When("I enter {string} as Date of Birth")]
        public void WhenIEnterAsDateOfBirth(string dob)
        {
            Log.Info("Entering DOB");
            _formPage.EnterDateOfBirth(dob);
        }

        [When("I enter {string} as Subject")]
        public void WhenIEnterAsSubject(string subject)
        {
            Log.Info("Entering subject");
            _formPage.EnterSubject(subject);
        }

        [When("I select {string} as Hobbies")]
        public void WhenISelectAsHobbies(string hobby)
        {
            Log.Info("Selecting Hobby");
            _formPage.SelectHobby(hobby);
        }

        [When("I enter {string} as Current Address")]
        public void WhenIEnterAsCurrentAddress(string address)
        {
            Log.Info("Entering address");
            _formPage.EnterCurrentAddress(address);
        }

        [When("I select {string} as State")]
        public void WhenISelectAsState(string state)
        {
            Log.Info("Selecting state");
            _formPage.SelectState(state);
        }

        [When("I select {string} as City")]
        public void WhenISelectAsCity(string city)
        {
            Log.Info("Selecting city");
            _formPage.SelectCity(city);
        }

        [When("I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            Log.Info("Clicking Submit");
            _formPage.ClickSubmit();
        }

        [Then("the form should be submitted successfully")]
        public void ThenTheFormShouldBeSubmittedSuccessfully()
        {
            _formPage.ConfirmSubmission();
        }
    }
}
