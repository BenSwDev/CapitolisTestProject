using System;
using OpenQA.Selenium;

namespace CapitolisTestProject
{
    internal class DynamicLoadPage : Page
    {
        public DynamicLoadPage(IWebDriver iDriver) : base(iDriver)
        {
        }

        internal Example2Page goToExample2Page()
        {
            IWebElement ExampleLink = Driver.FindElement(By.LinkText("Example 2: Element rendered after the fact"));
            if (ExampleLink != null)
            {
                logger.Info("Entered the example2 page");
            }
            else
            {
                logger.Error("Didn't entered the example2 page");
            }
            ExampleLink.Click();
            return (Example2Page)PageBuilder(ePageName.Example2Page);
        }
    }
}