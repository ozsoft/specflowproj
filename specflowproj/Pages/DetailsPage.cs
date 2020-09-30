
using NUnit.Framework;
using OpenQA.Selenium;

namespace specflowproj.Pages
{
    public class DetailsPage
    {

        IWebDriver driver;

        public DetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }



        public void EmployeeIdAssert(string expected)
        {

            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/div[1]/dl/dd[1]"));
            string actual = el.Text;
            Assert.AreEqual(expected, actual);


        }

        public void HourlyRateAssert(string expected)
        {

            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/div[1]/dl/dd[2]"));
            string actual = el.Text;
            Assert.AreEqual(expected, actual);

        }

        public void DayAssert(string expected)
        {
            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/div[1]/table/tbody/tr/td[1]"));
            string actual = el.Text;
            Assert.AreEqual(expected, actual);

        }

        public void HourAssert(string expected)
        {
            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/div[1]/table/tbody/tr/td[2]"));
            string actual = el.Text;
            Assert.AreEqual(expected, actual);


        }

        public void MinutesAssert(string expected)
        {

            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/div[1]/table/tbody/tr/td[3]"));
            string actual = el.Text;
            Assert.AreEqual(expected, actual);


        }



    }
}
