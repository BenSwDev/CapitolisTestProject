using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisTestProject
{
    public class MainPage : Page
    {
        public enum eCredentials
        {
            WithCredentials,
            WithoutCredentials
        }

        public MainPage(IWebDriver driver) : base(driver) { }

        public void openMainPage(eCredentials withOrWithout)
        {
            string credentials = withOrWithout == eCredentials.WithCredentials ? "admin:admin@" : "";
            string test_url = "http://" + credentials + "the-internet.herokuapp.com/";
            Driver.Url = test_url;
        }

        internal CheckBoxesPage goToCheckBoxesPage()
        {
            IWebElement checkBoxLink = Driver.FindElement(By.LinkText("Checkboxes"));
            checkBoxLink.Click();
            return (CheckBoxesPage)PageBuilder(ePageName.Checkboxes);
        }

        internal BasicAuthPage goToCBasicAuthPage()
        {
            IWebElement basicAuthLink = Driver.FindElement(By.LinkText("Basic Auth"));
            basicAuthLink.Click();
            return (BasicAuthPage)PageBuilder(ePageName.BasicAuth);
        }

        internal FramesPage goToCFramePage()
        {
            IWebElement framesLink = Driver.FindElement(By.LinkText("Frames"));
            framesLink.Click();
            return (FramesPage)PageBuilder(ePageName.Frames);
        }

        internal DynamicLoadPage goToDynamicLoadPage()
        {
            IWebElement dynamicsLink = Driver.FindElement(By.LinkText("Dynamic Loading"));
            dynamicsLink.Click();
            return (DynamicLoadPage)PageBuilder(ePageName.DynamicLoadPage);
        }

        internal JQueryUIMenusPage goToJQueryUIMenusPage()
        {
            IWebElement jqueryLing = Driver.FindElement(By.LinkText("JQuery UI Menus"));
            jqueryLing.Click();
            return (JQueryUIMenusPage)PageBuilder(ePageName.JQueryUIMenusPage);
        }
    }
}
