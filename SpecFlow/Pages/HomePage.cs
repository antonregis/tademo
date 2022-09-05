﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TADemo.Pages
{
    internal class HomePage
    {
        public void GoToWebsiteFeedbackPage(IWebDriver driver)
        {
            // Go to Website Feedback
            IWebElement contactButton = driver.FindElement(By.XPath("//a[contains(text(),'Contact')]"));
            contactButton.Click();
        }

        public void GoToEventPage(IWebDriver driver)
        {
            // Click Events button
            IWebElement eventButton = driver.FindElement(By.XPath("//a[contains(text(),'Events')]"));
            eventButton.Click();
        }

        public void EditEventPage(IWebDriver driver) 
        {
            // Click edit event
            IWebElement editEventButton = driver.FindElement(By.XPath("//a[contains(text(),'Edit')]"));
            editEventButton.Click();
        }

        public void DeleteEventPage(IWebDriver driver)
        {
            // Click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//a[contains(text(),'Delete')]"));
            deleteButton.Click();
        }

        public void ClickFirstArticlePage(IWebDriver driver)
        {
            // Click Events button
            IWebElement articleLink = driver.FindElement(By.XPath("//*[@class='node__title']/a[1]"));
            articleLink.Click();
        }
    }
}