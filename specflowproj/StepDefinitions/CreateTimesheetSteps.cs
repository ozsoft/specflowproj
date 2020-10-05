
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using specflowproj.Tests;
using OpenQA.Selenium.Chrome;
using System;

//to use tables
using TechTalk.SpecFlow.Assist;


//git status : gives you the status of the source code compared to the github rep
//git add . : this adds the modified files to now be able to be committed
//git commit -m "comment on checkin" : commenting on the commit
//git push https://github.com/ozsoft/specflowproj.git : push (forge, merge) commits to rep


namespace specflowproj
{
    [Binding]
    public class TestSteps
    {
        static IWebDriver driver;


        [Given("I navigate to homepage and clicked on create new")]
        public void GivenIhaveBrowsedToHomePageAndClickedCreateNew()
        {
            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl("https://codat-qa-task.azurewebsites.net/");

            HomePage hp = new HomePage(driver);
            hp.ClickOnCreateNewLink();
        }

        [When("I create new timesheet page for a single row with (.*) (.*) (.*) (.*) (.*)")]
        public void PopulateCreateNewTimesheetPageForSingleRow(string employeeId, string hourlyRate, string day, string hours, string minutes)
        {
            TimesheetTest ct = new TimesheetTest(driver);

            ct.CreateTestWithSingleRow(employeeId, hourlyRate, day, hours, minutes);
        }

        [When("I create new timesheet page for a double row with (.*) (.*) (.*) (.*) (.*)")]
        public void PopulateCreateNewTimesheetPageForDoubleRow(string employeeId, string hourlyRate, string day, string hours, string minutes)
        {
            TimesheetTest ct = new TimesheetTest(driver);

            ct.CreateTestWithMultipleRow(employeeId, hourlyRate, day, hours, minutes);
        }


        [When("I create new timesheet page with double row using data (.*) (.*) (.*) (.*) (.*)")]
        public void CreateNewTimesheetPageWithData(string employeeId, string hourlyRate, string day, string hours, string minutes)
        {
            TimesheetTest ct = new TimesheetTest(driver);

            ct.CreateTestWithMultipleRow(employeeId, hourlyRate, day, hours, minutes);
        }


        [Then("The result should be added to the list successfully with (.*) (.*) (.*) (.*) (.*)")]
        public void TheResultShouldBeAddedToTheListSuccessfully(string employeeId, string hourlyRate, string day, string hours, string minutes)
        {
            TimesheetTest ct = new TimesheetTest(driver);

            ct.AssertDetailsAreCorrect(employeeId, hourlyRate, day, hours, minutes);

            driver.Quit();

        }

        [Then("The result should be an error on saving the timesheet")]
        public void TheResultShouldBeAnErrorOnSavingTimesheet()
        {
            TimesheetTest ct = new TimesheetTest(driver);
            ct.AssertErrorPage();
            driver.Quit();

        }





    }
}
