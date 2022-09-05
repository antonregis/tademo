using System;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TADemo.Pages;
using TADemo.Utilities;

namespace TADemo
{
    [TestFixture]
    internal class Article_Test : CommonDriver
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
        public void AddComment()
        {
            // Go to Website Feedback Page
            HomePage homePageObj = new HomePage();
            homePageObj.ClickFirstArticlePage(driver);

            // TEST WEBSITE FEEDBACK PAGE
            ArticlePage articlePageObj = new ArticlePage();
            articlePageObj.AddComment(driver);
        }      

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}