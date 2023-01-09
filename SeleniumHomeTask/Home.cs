using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;


namespace SeleniumHomeTask
{
    public class Home : BasicPage
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
            ClickElem(wait, AdminXpath);
            return new Admin(Driver);
        }
    }
}
