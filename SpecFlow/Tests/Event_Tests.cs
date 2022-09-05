using System;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TADemo.Pages;
using TADemo.Utilities;

namespace TADemo.Tests
{
    [TestFixture]
    internal class Event_Tests : CommonDriver
    {
        [OneTimeSetUp]
        public void LoginFunction()
        {
            // Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // LOGIN TO tademo.codifyme.co.nz
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [Test]
        public void TC01_AddEvent()
        {
            // Go to Event Page
            HomePage homePage2Obj = new HomePage();
            homePage2Obj.GoToEventPage(driver);

            // Add an event
            EventPage eventPageObj = new EventPage();
            eventPageObj.AddEvent(driver);
        }

        [Test]
        public void TC02_EditEvent()
        {
            // Edit an event
            EventPage eventPageObj = new EventPage();
            eventPageObj.EditEvent(driver);
        }

        [Test]
        public void TC04_DeleteEvent()
        {
            // Delete an event
            EventPage eventPageObj = new EventPage();
            eventPageObj.DeleteEvent(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
