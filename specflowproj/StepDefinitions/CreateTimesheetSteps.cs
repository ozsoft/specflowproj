
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using specflowproj.Tests;
using OpenQA.Selenium.Chrome;

//git status : gives you the status of the source code compared to the github rep
//git add . : this adds the modified files to now be able to be committed
//git commit -m "comment on checkin" : commenting on the commit
//git push https://github.com/ozsoft/specflowproj.git : push (forge, merge) commits to rep


namespace specflowproj
{
    [Binding]
    public class TestSteps
    {
        IWebDriver driver;

        string employeeId = "CP200";
        string hourlyRate = "500";
        string day = "Tuesday";
        string hours = "10";
        string minutes = "20";

        [Given("I navigate to homepage and clicked on create new")]
        public void GivenIhaveBrowsedToHomePageAndClickedCreateNew()
        {

            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl("https://codat-qa-task.azurewebsites.net/");

            HomePage hp = new HomePage(driver);
            hp.ClickOnCreateNewLink();
        }


        [When("I create new timesheet page for a single row")]
        public void PopulateCreateNewTimesheetPageForSingleRow()
        {
            CreateTimesheet ct = new CreateTimesheet(driver);
            ct.CreateTestWithSingleRow(employeeId, hourlyRate, day, hours, minutes);
        }



        [When("I create new timesheet page for a double row")]
        public void PopulateCreateNewTimesheetPageForDoubleRow()
        {
            CreateTimesheet ct = new CreateTimesheet(driver);
            ct.CreateTestWithMultipleRow(employeeId, hourlyRate, day, hours, minutes);
        }

        [Then("The result should be an error on saving the timesheet")]
        public void TheResultShouldBeAnErrorOnSavingTimesheet()
        {
            CreateTimesheet ct = new CreateTimesheet(driver);

            ct.AssertErrorPage();
            driver.Quit();

        }

        [Then("The result should be added to the list successfully")]
        public void TheResultShouldBeAddedToTheListSuccessfully()
        {

            CreateTimesheet ct = new CreateTimesheet(driver);
            ct.AssertDetailsAreCorrect(employeeId, hourlyRate, day, hours, minutes);


            driver.Quit();

        }



    }
}
