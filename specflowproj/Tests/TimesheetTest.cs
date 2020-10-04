

using OpenQA.Selenium;
using specflowproj.Pages;

namespace specflowproj.Tests
{

    public class TimesheetTest
    {
        IWebDriver driver;


        public TimesheetTest(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void CreateTestWithSingleRow(string employeeId, string hourlyrate, string day, string hours, string minutes)
        {


            CreatePage cp = new CreatePage(driver);
            cp.EmployeeId.SendKeys(employeeId);
            cp.HourlyRate.SendKeys(hourlyrate);
            cp.HoursEnterNewEntry.SendKeys(hours);
            cp.MinutesEnterNewEntry.SendKeys(minutes);
            cp.DayEnterNewEntry(day);
            cp.SaveByCss.Click();


        }


        public void CreateTestWithMultipleRow(string employeeId, string hourlyrate, string day, string hours, string minutes)
        {


            CreatePage cp = new CreatePage(driver);
            cp.EmployeeId.SendKeys(employeeId);
            cp.HourlyRate.SendKeys(hourlyrate);
            cp.HoursEnterNewEntry.SendKeys(hours);
            cp.MinutesEnterNewEntry.SendKeys(minutes);
            cp.DayEnterNewEntry(day);
            cp.AddRow.Click();
            DetailsPage dp = cp.SaveClick();

            dp.DayAssert(day);

        }

        public void AssertDetailsAreCorrect(string employeeId, string hourlyrate, string day, string hours, string minutes)
        {
            DetailsPage dp = new DetailsPage(driver);
            if (!driver.Url.Contains("https://codat-qa-task.azurewebsites.net/Details"))
                throw new InvalidElementStateException();

            dp.EmployeeIdAssert(employeeId);
            //dp.HourlyRateAssert(hourlyrate);
            dp.DayAssert(day);
            dp.HourAssert(hours);
            dp.MinutesAssert(minutes);

        }

        public void AssertErrorPage()
        {
            ErrorPage ep = new ErrorPage(driver);
            ep.ErrorAssert("An error occurred while processing your request.");

        }




    }







}


