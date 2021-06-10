using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CapitolisTestProject
{
    public class IframePage : Page
    {
        public IframePage(IWebDriver driver) : base(driver) { }

        public void enterText()
        {
            Driver.SwitchTo().Frame("mce_0_ifr");
            IWebElement textBoxElement = Driver.FindElement(By.CssSelector("body"));
            logger.Info("text box contains: " + textBoxElement.Text);
            Thread.Sleep(3000);

            textBoxElement.Clear();
            logger.Info("text box contains: " + textBoxElement.Text);
            Thread.Sleep(3000);

            textBoxElement.SendKeys("Ben Swissa");
            logger.Info("text box contains: " + textBoxElement.Text);
            Driver.SwitchTo().DefaultContent();
        }
    }
}
