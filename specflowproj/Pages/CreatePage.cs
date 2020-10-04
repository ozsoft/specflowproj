
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace specflowproj.Pages
{
    public class CreatePage
    {
        IWebDriver driver;

        public CreatePage(IWebDriver driver)
        {
            this.driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(c => driver.FindElement(By.Id("Timesheet_EmployeeId")));

        }

        public IWebElement EmployeeId => driver.FindElement(By.Id("Timesheet_EmployeeId"));

        public IWebElement Save => driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/form/div[3]/input"));

        public IWebElement SaveByCss => driver.FindElement(By.CssSelector("body > div > main > div.row > div > form > div:nth-child(5) > input"));

        public IWebElement HourlyRate => driver.FindElement(By.Id("Timesheet_HourlyRate"));

        public IWebElement AddRow => driver.FindElement(By.Id("add-row"));

        public IWebElement HoursEnterNewEntry => driver.FindElement(By.Id("newEntry_Hours"));

        public IWebElement MinutesEnterNewEntry => driver.FindElement(By.Id("newEntry_Minutes"));

        public void MinutesEnter(string val, int row)
        {
            string s = string.Format("Timesheet_Entries_{0}__Minutes", row);
            IWebElement el = driver.FindElement(By.Id(s));
            el.SendKeys(val);

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

        public DetailsPage SaveClick()
        {
            IWebElement el = Save;
            el.Click();
            return new DetailsPage(driver);
        }


    }



}
