using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace SeleniumHomeTask
{
	public class LoginPage
	{
		private WebDriver Driver;

		private readonly By UsernameXpath = By.XPath("//input[@name='username']");
		private readonly By PasswordXpath = By.XPath("//input[@name='password']");
		private readonly By SubmitButtonXpath = By.XPath("//button[@type='submit']");

		public LoginPage(WebDriver Driver)
		{
			this.Driver = Driver;
		}

		public Home Login(string username, string password)
		{
			// wait for page downloading
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			Driver.FindElement(UsernameXpath).SendKeys(username);
			Driver.FindElement(PasswordXpath).SendKeys(password);
			Driver.FindElement(SubmitButtonXpath).Click();

			return new Home(Driver);
		}
	}
}
