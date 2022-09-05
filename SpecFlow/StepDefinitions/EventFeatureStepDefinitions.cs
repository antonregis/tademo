using OpenQA.Selenium.Chrome;
using System;
using TADemo.Pages;
using TADemo.Utilities;
using TechTalk.SpecFlow;

namespace TADemo.StepDefinitions
{
    [Binding]
    public class EventFeatureStepDefinitions : CommonDriver
    {
        // Initialize page objects
        LoginPage loginPageObj = new LoginPage();
        HomePage homePage2Obj = new HomePage();
        EventPage eventPageObj = new EventPage();


        [Given(@"login to TADemo website")]
        public void GivenLoginToTADemoWebsite()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // LOGIN TO tademo.codifyme.co.nz
            loginPageObj.LoginSteps(driver);
        }

        [Given(@"navigate to event page")]
        public void GivenNavigateToEventPage()
        {
            // Go to Event Page            
            homePage2Obj.GoToEventPage(driver);
        }

        [When(@"add an event")]
        public void WhenAddAnEvent()
        {
            // Add an event
            eventPageObj.AddEvent(driver);
        }

        [Then(@"the event should be created successfully")]
        public void ThenTheEventShouldBeCreatedSuccessfully()
        {
            
        }

        [Given(@"click edit event")]
        public void GivenClickEditEvent()
        {
            homePage2Obj.EditEventPage(driver);
        }

        [When(@"edit the event")]
        public void WhenEditTheEvent()
        {
            // Edit an event
            eventPageObj.EditEvent(driver);
        }

        [Then(@"the event should be edited successfully")]
        public void ThenTheEventShouldBeEditedSuccessfully()
        {
            
        }

        [Given(@"click delete event")]
        public void GivenClickDeleteEvent()
        {
            homePage2Obj.DeleteEventPage(driver);
        }

        [When(@"click confirm delete")]
        public void WhenClickConfirmDelete()
        {
            eventPageObj.DeleteEvent(driver);
        }

        [Then(@"the event should be deleted successfully")]
        public void ThenTheEventShouldBeDeletedSuccessfully()
        {
            
        }
    }
}