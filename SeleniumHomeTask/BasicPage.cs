using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumHomeTask
{
    public class BasicPage
    {
        public void ClickElem(WebDriverWait wait, By elem)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elem)).Click();
        }

        public void SendKeysElem(WebDriverWait wait, By elem, string keys)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(elem)).SendKeys(keys);
        }
    }
}
