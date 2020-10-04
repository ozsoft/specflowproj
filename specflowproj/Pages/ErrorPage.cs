using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace specflowproj.Pages
{
    public class ErrorPage
    {
        IWebDriver driver;
        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ErrorAssert(string expected)
        {

            string errorMessage = ErrorMessageValidation();
            Assert.AreEqual(expected, errorMessage);

        }


        public string ErrorMessageValidation()
        {
            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/h2"));
            return el.Text;
        }


    }
}
