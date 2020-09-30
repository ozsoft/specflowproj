
using NUnit.Framework;
using OpenQA.Selenium;
using specflowproj.Pages;

namespace specflowproj.Tests
{

    public class CreateTimesheet
    {
        IWebDriver driver;


        public CreateTimesheet(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void CreateTestWithSingleRow(string employeeId, string hourlyrate, string day, string hours, string minutes)
        {


            CreatePage cp = new CreatePage(driver);
            cp.EmployeeIdEnter(employeeId);
            cp.HourlyRateEnter(hourlyrate);
            cp.HoursEnterNewEntry(hours);
            cp.MinutesEnterNewEntry(minutes);
            cp.DayEnterNewEntry(day);
            cp.SaveClick();

        }


        public void CreateTestWithMultipleRow(string employeeId, string hourlyrate, string day, string hours, string minutes)
        {


            CreatePage cp = new CreatePage(driver);
            cp.EmployeeIdEnter(employeeId);
            cp.HourlyRateEnter(hourlyrate);
            cp.HoursEnterNewEntry(hours);
            cp.MinutesEnterNewEntry(minutes);
            cp.DayEnterNewEntry(day);
            cp.AddRow();
            cp.SaveClick();



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
            CreatePage cp = new CreatePage(driver);
            cp.ErrorAssert("An error occurred while processing your request.");

        }




    }







}


