using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TADemo
{
    internal class Tests
    {
        static void Main(string[] args)
        {
            // LOG IN TO tademo.codifyme.co.nz
            
            // Open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Launch TADemo website login
            driver.Navigate().GoToUrl("https://tademo.codifyme.co.nz/user/login");

            // Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("edit-name"));
            usernameTextbox.SendKeys("tademo");

            // Identify password textbox and enter valid username
            IWebElement passwordTextbox = driver.FindElement(By.Id("edit-pass"));
            passwordTextbox.SendKeys("Passw0rdDem0");

            // Identify log in button and click
            IWebElement loginButton = driver.FindElement(By.Id("edit-submit"));
            loginButton.Click();

            // Check if login is successful
            IWebElement logoutButton = driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));

            if (logoutButton.Text == "Logout")
            {
                Console.WriteLine(" ■ Pass: Login successful");
            }
            else 
            {
                Console.WriteLine(" ■ Failed: Login unsuccessful");
            }



            // TEST WEBSITE FEEDBACK PAGE

            // Go to Website Feedback
            IWebElement contactButton = driver.FindElement(By.XPath("//a[contains(text(),'Contact')]"));
            contactButton.Click();

            // Enter subject textbox
            IWebElement subjectTextbox = driver.FindElement(By.Id("edit-subject-0-value"));
            subjectTextbox.SendKeys("Testing Website Feedback");

            // Enter message textbox
            IWebElement messageTextbox = driver.FindElement(By.Id("edit-message-0-value"));
            messageTextbox.SendKeys("The quick brown fox jumps over the lazy dog.");

            // Click send message button
            IWebElement sendMessageButton = driver.FindElement(By.Id("edit-submit"));
            sendMessageButton.Click();

            // Check if message was sent successfully

            // Get status message
            IWebElement statusWebsiteFeedbackMessage = driver.FindElement(By.ClassName("messages--status"));

            if (statusWebsiteFeedbackMessage.Text.Contains("Your message has been sent."))
            {
                Console.WriteLine(" ■ Pass: Website Feedback successful");
            }
            else 
            {
                Console.WriteLine(" ■ Failed: Website Feedback unsuccessful");
            }



            // TEST EVENTS PAGE

            // Click Events button
            IWebElement eventButton = driver.FindElement(By.XPath("//a[contains(text(),'Events')]"));
            eventButton.Click();

            
            // Add an Event
            IWebElement addEventButton = driver.FindElement(By.XPath("//a[contains(text(),'Add Event')]"));
            addEventButton.Click();

            // Enter event name textbox
            IWebElement eventNameTextbox = driver.FindElement(By.Id("edit-title-0-value"));
            eventNameTextbox.SendKeys("Maraetai Half Marathon");

            // Click event type dropdown
            IWebElement eventTypeDropdown = driver.FindElement(By.Id("edit-field-event-type"));
            eventTypeDropdown.Click();

            // Select event type
            IWebElement eventTypeOption = driver.FindElement(By.XPath("//option[contains(text(),'Swimming')]"));
            eventTypeOption.Click();

            // Enter event date textbox
            IWebElement eventDateTextbox = driver.FindElement(By.Id("edit-field-event-date-0-value-date"));
            eventDateTextbox.SendKeys("3/28/2023");

            // Enter address textbox
            IWebElement addressTextbox = driver.FindElement(By.Id("edit-field-event-address-0-value"));
            addressTextbox.SendKeys("Maraetai Park");

            // Enter suburb textbox
            IWebElement suburbTextbox = driver.FindElement(By.Id("edit-field-event-suburb-0-value"));
            suburbTextbox.SendKeys("Beachlands");

            // Enter city textbox
            IWebElement cityTextbox = driver.FindElement(By.Id("edit-field-event-city-0-value"));
            cityTextbox.SendKeys("Maraetai City");

            // Click Save button
            IWebElement saveButton = driver.FindElement(By.Id("edit-submit"));
            saveButton.Click();

            // Get add status message
            IWebElement addEventstatusMessage = driver.FindElement(By.ClassName("messages--status"));

            if (addEventstatusMessage.Text.Contains("Event Maraetai Half Marathon has been created."))
            {
                Console.WriteLine(" ■ Pass: Add event successful");
            }
            else
            {
                Console.WriteLine(" ■ Failed: Add event unsuccessful");
            }


            // Edit an event
            
            // Click edit event
            IWebElement editEventButton = driver.FindElement(By.XPath("//a[contains(text(),'Edit')]"));
            editEventButton.Click();

            // Enter event name textbox
            IWebElement eventName2Textbox = driver.FindElement(By.Id("edit-title-0-value"));
            eventName2Textbox.Clear();
            eventName2Textbox.SendKeys("Maraetai Full Marathon");

            // Click event type dropdown
            IWebElement eventType2Dropdown = driver.FindElement(By.Id("edit-field-event-type"));
            eventType2Dropdown.Click();

            // Select event type
            IWebElement eventType2Option = driver.FindElement(By.XPath("//option[contains(text(),'Running')]"));
            eventType2Option.Click();

            // Enter event date textbox
            IWebElement eventDate2Textbox = driver.FindElement(By.Id("edit-field-event-date-0-value-date"));
            eventDate2Textbox.Clear();
            eventDate2Textbox.SendKeys("3/28/2022");

            // Enter address textbox
            IWebElement address2Textbox = driver.FindElement(By.Id("edit-field-event-address-0-value"));
            address2Textbox.Clear();
            address2Textbox.SendKeys("Maraetai Beach");

            // Enter suburb textbox
            IWebElement suburb2Textbox = driver.FindElement(By.Id("edit-field-event-suburb-0-value"));
            suburb2Textbox.Clear();
            suburb2Textbox.SendKeys("Maraetai");

            // Enter city textbox
            IWebElement city2Textbox = driver.FindElement(By.Id("edit-field-event-city-0-value"));
            city2Textbox.Clear();
            city2Textbox.SendKeys("Auckland Region");

            // Click Save button
            IWebElement save2Button = driver.FindElement(By.Id("edit-submit"));
            save2Button.Click();

            // Get edit status message
            IWebElement eventEditStatusMessage = driver.FindElement(By.ClassName("messages--status"));

            if (eventEditStatusMessage.Text.Contains("Event Maraetai Full Marathon has been updated."))
            {
                Console.WriteLine(" ■ Pass: Edit event successful");
            }
            else
            {
                Console.WriteLine(" ■ Failed: Edit event unsuccessful");
            }


            // Delete an event
            
            // Click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//a[contains(text(),'Delete')]"));
            deleteButton.Click();

            // Click confirm delete button
            IWebElement deleteConfirmButton = driver.FindElement(By.Id("edit-submit"));
            deleteConfirmButton.Click();

            // Get delete status message
            IWebElement eventDeleteStatusMessage = driver.FindElement(By.ClassName("messages--status"));

            if (eventDeleteStatusMessage.Text.Contains("The Event Maraetai Full Marathon has been deleted."))
            {
                Console.WriteLine(" ■ Pass: Delete event successful");
            }
            else
            {
                Console.WriteLine(" ■ Failed: Delete event unsuccessful");
            }
        }
    }
}
