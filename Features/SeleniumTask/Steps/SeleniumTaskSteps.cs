using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Edge;
using System.Xml.Linq;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

using SeleniumHomeTask;

namespace SeleniumTask.Steps
{
    [Binding]
    public class SeleniumTaskSteps
    {
        readonly WebDriver Driver = new FirefoxDriver();
        Home home;
        Admin admin;
        PayGrades payGrades;
        AddPayGrades addPayGrades;

        [Given(@"login to the page")]
        public void GivenLoginToThePage()
        {
            Driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            Driver.Manage().Window.Maximize();

            LoginPage loginPage = new LoginPage(Driver);
            home = loginPage.Login("Admin", "admin123");
        }
        
        [Given(@"go to admin")]
        public void GivenGoToAdmin()
        {
            admin = home.MoveToAdmin();
        }
        
        [Given(@"go to pay grades")]
        public void GivenGoToPayGrades()
        {
            payGrades = admin.MoveToPayGradesPage();
        }
        
        [Given(@"add pay grade")]
        public void GivenAddPayGrade()
        {
            addPayGrades = payGrades.MoveToAddPayGradesPage();
        }
        
        [Given(@"delete new currency")]
        public void GivenDeleteNewCurrency()
        {
            payGrades = addPayGrades.DeleteCurrency();
        }
        
        [When(@"added job title and new currency")]
        public void WhenAddedJobTitleAndNewCurrency()
        {
            addPayGrades.AddJobTitleAndCurrency();
        }
        
        [Then(@"check that currency added properly")]
        public void ThenCheckThatCurrencyAddedProperly()
        {
            addPayGrades.IsCurrencyAddedRight().Equals(true);
        }
        
        [Then(@"check that pay grade added properly")]
        public void ThenCheckThatPayGradeAddedProperly()
        {
            payGrades.IsPayGradeAdded().Equals(true);
        }
    }
}
