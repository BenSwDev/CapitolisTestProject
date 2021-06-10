using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisTestProject
{
    public class FramesPage : Page
    {
        public FramesPage(IWebDriver driver) : base(driver) { }

        public IframePage goToIframePage()
        {
            IWebElement iFramesLink = Driver.FindElement(By.LinkText("iFrame"));
            if (iFramesLink != null)
            {
                logger.Info("Entered to iframe page");
            }
            else
            {
                logger.Info("Didn't entered to iframe page");
            }
            iFramesLink.Click();
            return (IframePage)PageBuilder(ePageName.Iframe);
        }
    }
}
