## Test Automation Demo (tademo.codifyme.co.nz)

This is a test automation practice project, applying what I've learned from the first 4 weeks of Industry Connect training. I created a website (tademo.codifyme.co.nz) to run a happy pass test automation. This tests the login feature, Website feedback, and Events page. To absorb better from what I've learned from the training, I will create four different vesions of the test automation which are as follows, segrated by folders:
1. **Basic - Classic example. The simplest form.** 
2. **POM - Page Object Model**
3. **NUnit - NUnit test framework**
4. **SpecFlow**


---
## Basic

Description of the project here. The quick brown fox jumps over the lazy dog. 

NugGet Packages used:
1. Microsoft.NETCore.App
2. Selenium.Support
3. Selenium.WebDriver
4. Selenium.WebDriver.ChromeDriver

Observations:
- I noticed that the website was responsive enough that I did not have to use DotNetSeleniumExtras.WaitHelpers for this project.
- In checking the event status message returns a two line message, so I used 'contains()' string method to capture the message that I only needed to check my expected results.

---
## POM 

Page Object Model. Description of the project here. The quick brown fox jumps over the lazy dog. 

NugGet Packages used:
1. Microsoft.NETCore.App
2. Selenium.Support
3. Selenium.WebDriver
4. Selenium.WebDriver.ChromeDriver
5. DotNetSeleniumExtras.WaitHelpers

Observations:
- Scripts are organized into folders: Pages and Tests. If there is any handy custom tool/class that you need to create like 'Explicit Waits', then you can put them in a 'Utilities' folder as good practice.
- 'Pages' folder contains the page classes. Every page tested on the website lives here with a corresponding page class file. A page class contains method/s detailing the test steps. These methods will be called upon later from the main TADemoTests class in "Tests" folder.
- 'Tests' folder contains the main TADemo_Tests class which runs the test cases. This calls the methods created in 'Pages' and if any in 'Utilities' folder.
- 'Utilities' folder contains (if any) your custom tools/classes that can help you like Explicit Waits and CommonDriver.


---
## NUnit 

Description of the project here. The quick brown fox jumps over the lazy dog. 

NugGet Packages used:
1. Microsoft.NET.Test.Sdk
2. Selenium.Support
3. Selenium.WebDriver
4. Selenium.WebDriver.ChromeDriver
5. DotNetSeleniumExtras.WaitHelpers
6. NUnit
7. NUnit3TestAdapter

Observations:
- 'static void Main(string[] args)' is removed
- NUnit test project, not a console anymore. Starting to become a test program now
- Attribute tags are used to classify between classes and methods?
- Explain CommonDriver. Inheritance concept.
- Try Catch Throw
- Assertions now used. They are left inside in each page class.

---
## SpecFlow

Description of the project here. The quick brown fox jumps over the lazy dog. 

New stuff:
1. CommonDriver (Inheritance)
2. Assertion added for validation
3. Try and catch

NugGet Packages used:
1. Microsoft.NET.Test.Sdk
2. Selenium.Support
3. Selenium.WebDriver
4. Selenium.WebDriver.ChromeDriver
5. DotNetSeleniumExtras.WaitHelpers
6. NUnit
7. NUnit3TestAdapter
8. SpecFlow
9. SpecFlow.NUnit
10. SpecFlow.Tools.MsBuild.Generation

Extension used:
1. SpecFlow for Visual Studio 2022