using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace specflowproj
{
    public class TimesheetHomePage
    {
        IWebDriver driver;


        public void startBrowser()
        {
            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl("https://codat-qa-task.azurewebsites.net/");

        }

        public TimesheetHomePage()
        {
        }
    }
}
