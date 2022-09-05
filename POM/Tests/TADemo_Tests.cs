using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TADemo.Pages;

namespace TADemo
{
    internal class TADemo_Tests
    {
        static void Main(string[] args)
        {
            // Open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // LOGIN TO tademo.codifyme.co.nz
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
            
            // Go to Website Feedback Page
            HomePage homePageObj = new HomePage();
            homePageObj.GoToWebsiteFeedbackPage(driver);
                        
            // TEST WEBSITE FEEDBACK PAGE
            WebsiteFeedbackPage websiteFeedbackPageObj = new WebsiteFeedbackPage();
            websiteFeedbackPageObj.WFSteps(driver);

            // Go to Event Page
            HomePage homePage2Obj = new HomePage();
            homePage2Obj.GoToEventPage(driver);

            // TEST EVENTS PAGE
            
            // Add an event
            EventPage eventPageObj = new EventPage();
            eventPageObj.AddEvent(driver);

            // Edit an event
            eventPageObj.EditEvent(driver);

            // Delete an event
            eventPageObj.DeleteEvent(driver);
        }
    }
}
