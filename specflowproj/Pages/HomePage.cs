
using OpenQA.Selenium;

namespace specflowproj
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;


        }

        public void ClickOnCreateNewLink()
        {
            IWebElement el = driver.FindElement(By.XPath("/html/body/div/main/p/a"));
            el.Click();
        }




    }


}



