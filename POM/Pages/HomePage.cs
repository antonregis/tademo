using System;
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
    }
}
