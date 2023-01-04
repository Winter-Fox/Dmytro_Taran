using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;


namespace SeleniumHomeTask
{
    public class Home
    {
        private WebDriver Driver;
        private readonly By AdminXpath = By.XPath("//*[@id=\'app\']/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span");


        public Home(WebDriver Driver)
        {
            this.Driver = Driver;
        }

        public Admin MoveToAdmin()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(AdminXpath)).Click();
            return new Admin(Driver);
        }
    }
}
