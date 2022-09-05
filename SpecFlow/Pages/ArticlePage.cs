using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TADemo.Pages
{
    internal class ArticlePage
    {
        public void AddComment(IWebDriver driver) 
        {
            // Enter subject name textbox
            Thread.Sleep(2000);
            IWebElement subjectTextbox = driver.FindElement(By.Id("edit-subject-0-value"));
            subjectTextbox.SendKeys("Test comment");

            // Enter comment textarea
            // /html
            IWebElement commentTextArea = driver.FindElement(By.Id("edit-field-comment-body-0-value"));
            commentTextArea.SendKeys("Commenting to an article...");

            // Click preview button
            IWebElement previewButton = driver.FindElement(By.Id("edit-preview"));
            previewButton.Click();

            // Click save button
            IWebElement saveButton = driver.FindElement(By.Id("edit-submit"));
            saveButton.Click();            

            // Get add status message
            IWebElement addEventstatusMessage = driver.FindElement(By.ClassName("messages--status"));

            // Assertion
            Assert.That(addEventstatusMessage.Text.Contains("Your comment has been posted."), "Failed: Add comment unsuccessful");
        }
    }
}