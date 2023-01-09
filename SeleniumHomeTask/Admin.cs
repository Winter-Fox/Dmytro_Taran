using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace SeleniumHomeTask
{
    public class Admin : BasicPage
    {
        private WebDriver Driver;

        //Go to user managment tab
        private readonly By JobsTabXpath = By.XPath("//*[@id='app']/div[1]/div[1]/header/div[2]/nav/ul/li[2]");
        // Go to pay grades
        private readonly By PayGradesTabXpath = By.XPath("//*[@id='app']/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul/li[2]");

        public Admin(WebDriver Driver)
        {
            this.Driver = Driver;
        }

        public PayGrades MoveToPayGradesPage()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            ClickElem(wait, JobsTabXpath);
            ClickElem(wait, PayGradesTabXpath);

            return new PayGrades(Driver);
        }

    }
}
