using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace SeleniumHomeTask
{
    public class AddPayGrades
    {
        private WebDriver Driver;
        private string MinSalary = "12";
        private string MaxSalary = "200";

        // Name input
        private readonly By NameInputXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div/div/div[2]/input");
        // Save job name button
        private readonly By SaveJobNameButtonXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]");

        // Add currency button
        private readonly By AddCurrencyButtonXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/div/div[1]/div/button");
        // Add currency button
        private readonly By SelectCurrencyXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/form/div[1]/div/div/div/div[2]/div/div/div[2]");
        // Add currency button
        private readonly By CurrencyXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/form/div[1]/div/div/div/div[2]/div/div[2]/div[3]");
        // Minimal salary input
        private readonly By MinSalaryInputXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/form/div[2]/div/div[1]/div/div[2]/input");
        // Maximal salary input
        private readonly By MaxSalaryInputXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/form/div[2]/div/div[2]/div/div[2]/input");
        // Save currency button
        private readonly By SaveCurrencyButtonXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/form/div[3]/button[2]");

        // Minimal salary after adding
        private readonly By MinSalaryXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/div/div[3]/div/div[2]/div/div/div[3]/div");
        // Maximal salary after adding
        private readonly By MaxSalaryXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/div/div[3]/div/div[2]/div/div/div[4]/div");

        // Select currency button
        private readonly By SelectCurrencyButtonXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/div/div[3]/div/div[2]/div/div/div[1]/div/div/label/span");
        // Delete selected currency button
        private readonly By DeleteSelectedButtonXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/button");
        // Yes I'm sure god damn it button
        private readonly By AmSureButtonXpath = By.XPath("//*[@id='app']/div[3]/div/div/div/div[3]/button[2]");
        // cancel button
        private readonly By CancelButtonXpath = By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div[1]/div/form/div[2]/button[1]");


        public AddPayGrades(WebDriver Driver)
        {
            this.Driver = Driver;
        }

        public void AddJobTitleAndCurrency()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            // Add new job with VeryRandomName title
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(NameInputXpath)).SendKeys("VeryRandomName");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SaveJobNameButtonXpath)).Click();

            //Add new currency
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AddCurrencyButtonXpath)).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SelectCurrencyXpath)).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CurrencyXpath)).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(MinSalaryInputXpath)).SendKeys(MinSalary);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(MaxSalaryInputXpath)).SendKeys(MaxSalary);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SaveCurrencyButtonXpath)).Click();
        }

        public bool IsCurrencyAddedRight()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            // Get actual values of min and max currencies and check them against strater ones
            string actualMinSalary = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(MinSalaryXpath)).Text;
            string actualMaxSalary = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(MaxSalaryXpath)).Text;
            return ((actualMinSalary == MinSalary + ".00") && (actualMaxSalary == MaxSalary + ".00"));
        }

        public PayGrades DeleteCurrency()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SelectCurrencyButtonXpath)).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteSelectedButtonXpath)).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AmSureButtonXpath)).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CancelButtonXpath)).Click();

            return new PayGrades(Driver);
        }
    }
}
