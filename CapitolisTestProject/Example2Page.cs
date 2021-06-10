using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CapitolisTestProject
{
    internal class Example2Page : Page
    {
        public Example2Page(IWebDriver iDriver) : base(iDriver)
        {
        }

        internal void clickSStartButtonAndEnsureHelloWorldAppear()
        {
            IWebElement startBtn = Driver.FindElement(By.CssSelector("#start > button"));
            try
            {
                startBtn.Click();
                logger.Info("Start button clicked");
            }
            catch
            {
                logger.Error("Can't click on the start button");
            }

            logger.Info("Waiting for Hello World! to show up...");
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.FindElement(By.CssSelector("#finish > h4")).Text.Contains("Hello World!"));
                logger.Info("Hello World! showed up");
            }
            catch
            {
                logger.Error("Hello World! didn't showed up");
            }
        }
    }
}