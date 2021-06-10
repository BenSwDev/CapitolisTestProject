using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CapitolisTestProject
{
    internal class JQueryUIMenusPage : Page
    {
        public JQueryUIMenusPage(IWebDriver iDriver) : base(iDriver)
        {
        }

        internal void pressOnExcelDownload()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#ui-id-2")));

            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#ui-id-4")));

            action = new Actions(Driver);
            action.MoveToElement(element).Perform();

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#ui-id-8")));

            action = new Actions(Driver);
            action.MoveToElement(element).Click();

            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }
    }
}