using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisTestProject
{
    public class BasicAuthPage : Page
    {
        public BasicAuthPage(IWebDriver driver) : base(driver) { }

        public void isTestPassed()
        {
            if (Driver.PageSource.Contains("Congratulations"))
            {
                logger.Info("Test Passed");
            }
            else
            {
                logger.Error("Test Failed");
            }
        }
    }
}
