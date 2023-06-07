using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CucumberTest.Pages
{
    internal class MainPage
    {
        private IWebDriver webDriver { get; }
        private WebDriverWait wait { get; }

        public MainPage(IWebDriver webDriver1)
        {
            this.webDriver = webDriver1;
            this.wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        private IWebElement lnkAdmin => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span"));

        public void GoToAdmin()
        {
            webDriver.Navigate().Refresh();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span")));
            lnkAdmin.Click();
        }

        private IWebElement lnkJob => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/span"));
        private IWebElement lnkJobTitles => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul/li[1]/a"));

        public void GoToJobTitles()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/span")));
            lnkJob.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul/li[1]/a")));
            lnkJobTitles.Click();
        }

        private IWebElement lnkAddJob => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div[1]/div/button"));

        public void GoToAdd()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div[1]/div/button")));
            lnkAddJob.Click();
        }

        private IWebElement lnkJobTitle => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/input"));
        private IWebElement lnkJobDescription => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/textarea"));
        private IWebElement lnkNote => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[4]/div/div[2]/textarea"));

        public void InsertAddData(string jobTitle, string jobDescription, string note)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/input")));
            lnkJobTitle.SendKeys(jobTitle);

            lnkJobDescription.SendKeys(jobDescription);
            lnkNote.SendKeys(note);
        }

        private IWebElement lnkSave => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[5]/button[2]"));

        public void ClickSave()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[5]/button[2]")));
            lnkSave.Click();
        }

        private IWebElement lnkDelete => webDriver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/div[3]/div/div/div/div/div/div[1]/div[2]/div/div/button[1]/i"));
        private IWebElement lnkYes => webDriver.FindElement(By.XPath("//*[@id=\"app\"]/div[3]/div/div/div/div[3]/button[2]"));

        public void DeleteStudent()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/div[3]/div/div/div/div/div/div[1]/div[2]/div/div/button[1]/i")));
            lnkDelete.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div[3]/div/div/div/div[3]/button[2]")));
            lnkYes.Click();
        }

        public void ClosesBrowser()
        {
            webDriver.Close();
        }
    }
}