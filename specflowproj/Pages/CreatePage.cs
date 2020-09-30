using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace specflowproj.Pages
{
    public class CreatePage
    {
        IWebDriver driver;

        public CreatePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void EmployeeIdEnter(string val)
        {
            IWebElement el = driver.FindElement(By.Id("Timesheet_EmployeeId"));
            el.SendKeys(val);

        }

        public void HourlyRateEnter(string val)
        {
            IWebElement el = driver.FindElement(By.Id("Timesheet_HourlyRate"));
            el.SendKeys(val);

        }

        public void ErrorAssert(string expected)
        {

            string errorMessage = ErrorMessageValidation();
            Assert.AreEqual(expected, errorMessage);

        }


        public void DayEnterNewEntry(string val)
        {
            string s = string.Format("newEntry_Day");
            IWebElement el = driver.FindElement(By.Id(s));
            SelectElement sel = new SelectElement(el);


            sel.SelectByText(val);

        }

        public void DayEnter(string val, int row)
        {

            string s = string.Format("Timesheet_Entries_{0}__Day", row);
            IWebElement el = driver.FindElement(By.Id(s));
            SelectElement sel = new SelectElement(el);


            sel.SelectByText(val);
        }

        public void HoursEnter(string val, int row)
        {
            string s = string.Format("Timesheet_Entries_{0}__Hours", row);
            IWebElement el = driver.FindElement(By.Id(s));
            el.SendKeys(val);

        }



        public void HoursEnterNewEntry(string val)
        {
            string s = string.Format("newEntry_Hours");
            IWebElement el = driver.FindElement(By.Id(s));
            el.SendKeys(val);

        }



        public void MinutesEnterNewEntry(string val)
        {
            string s = string.Format("newEntry_Minutes");
            IWebElement el = driver.FindElement(By.Id(s));
            el.SendKeys(val);

        }


        public void MinutesEnter(string val, int row)
        {
            string s = string.Format("Timesheet_Entries_{0}__Minutes", row);
            IWebElement el = driver.FindElement(By.Id(s));
            el.SendKeys(val);

        }

        public void AddRow()
        {
            IWebElement el = driver.FindElement(By.Id("add-row"));
            el.Click();

        }

        public void SaveClick()
        {
            IWebElement el = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/form/div[3]/input"));
            el.Click();

        }



        public string ErrorMessageValidation()
        {
            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/h2"));
            return el.Text;
        }


    }



}
