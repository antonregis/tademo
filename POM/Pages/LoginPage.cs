using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TADemo.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // LOG IN TO tademo.codifyme.co.nz

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
        }
    }
}
