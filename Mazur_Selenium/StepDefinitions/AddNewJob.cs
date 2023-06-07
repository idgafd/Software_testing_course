using OpenQA.Selenium;
using CucumberTest.Pages;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Chrome;

namespace CucumberTest.StepDefinitions
{
    [Binding]
    public sealed class AddNewJobStepDefinitions
    {
        private IWebDriver webDriver = new ChromeDriver();
        private MainPage mainPage;

        [Given(@"User logged in with data")]
        public void GivenUserLoggedInWithData(Table table)
        {
            webDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            LogInPage logInPage = new LogInPage(webDriver);
            dynamic data = table.CreateDynamicInstance();
            logInPage.Login((string)data.UserName, (string)data.Password);
        }

        [When(@"User click on Admin")]
        public void WhenUserClickOnAdmin()
        {
            mainPage = new MainPage(webDriver);
            mainPage.GoToAdmin();
        }

        [When(@"User click on Job Titles")]
        public void WhenUserClickOnJobTitles()
        {
            mainPage.GoToJobTitles();
        }

        [When(@"User click on Add")]
        public void WhenUserClickOnAdd()
        {
            mainPage.GoToAdd();
        }

        [When(@"User insert data")]
        public void WhenUserInsertData(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            mainPage.InsertAddData((string)data.JobTitle, (string)data.JobDescription, (string)data.Note);
        }

        [When(@"User click on Save")]
        public void WhenUserClickOnSave()
        {
            mainPage.ClickSave();
        }

        [When(@"User delete Student")]
        public void ThenUserDeleteStudent()
        {
            mainPage.DeleteStudent();
        }

        [Then(@"User closes the browser")]
        public void ThenUserClosesTheBrowser()
        {
            mainPage.ClosesBrowser();
        }

    }
}