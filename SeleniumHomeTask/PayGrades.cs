using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace SeleniumHomeTask
{
    public class PayGrades
    {
        private WebDriver Driver;

        // Add button
        private readonly By AddButtonXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div/div[1]/div/button");
        // New pay grade
        private readonly By NewPayGradeXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div/div[3]/div/div[2]/div[6]/div");

        public PayGrades(WebDriver Driver)
        {
            this.Driver = Driver;
        }

        public AddPayGrades MoveToAddPayGradesPage()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(AddButtonXpath)).Click();

            return new AddPayGrades(Driver);
        }

        public bool IsPayGradeAdded()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            try
            {
                Driver.FindElement(NewPayGradeXpath);

                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
