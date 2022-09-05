using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TADemo.Pages
{
    internal class WebsiteFeedbackPage
    {
        public void WFSteps(IWebDriver driver) 
        {
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
        }
    }
}
