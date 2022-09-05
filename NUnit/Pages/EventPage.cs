using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TADemo.Pages
{
    internal class EventPage
    {
        public void AddEvent(IWebDriver driver) 
        {
            // Click Add an event
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

            // Assertion
            Assert.That(addEventstatusMessage.Text.Contains("Event Maraetai Half Marathon has been created."), "Failed: Add event unsuccessful");
        }

        public void EditEvent(IWebDriver driver)
        {
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

            // Assertion
            Assert.That(eventEditStatusMessage.Text.Contains("Event Maraetai Full Marathon has been updated."), "Failed: Edit event unsuccessful");
        }

        public void DeleteEvent(IWebDriver driver)
        {
            // Delete an event

            // Click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//a[contains(text(),'Delete')]"));
            deleteButton.Click();

            // Click confirm delete button
            IWebElement deleteConfirmButton = driver.FindElement(By.Id("edit-submit"));
            deleteConfirmButton.Click();

            // Get delete status message
            IWebElement eventDeleteStatusMessage = driver.FindElement(By.ClassName("messages--status"));

            Assert.That(eventDeleteStatusMessage.Text.Contains("The Event Maraetai Full Marathon has been deleted."), "Failed: Delete event unsuccessful");
        }
    }
}