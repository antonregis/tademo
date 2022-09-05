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
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            try 
            {
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
            }
            catch (Exception ex) 
            {
                Assert.Fail("Failed: Login unsuccessful", ex.Message);
                throw;
            }
        }
    }
}