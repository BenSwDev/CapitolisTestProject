using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisTestProject
{
    public class Page
    {
        public static IWebDriver Driver { get; set; }
        public static Page page;
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public enum ePageName
        {
            MainPage,
            Checkboxes,
            BasicAuth,
            Frames,
            Iframe,
            DynamicLoadPage,
            Example2Page,
            JQueryUIMenusPage
        }

        public Page(IWebDriver iDriver)
        {
            Driver = iDriver;
        }

        public static Page PageBuilder(ePageName enumPageName)
        {
            switch (enumPageName)
            {
                case ePageName.MainPage:
                    page = new MainPage(Driver);
                    break;
                case ePageName.Checkboxes:
                    page = new CheckBoxesPage(Driver);
                    break;
                case ePageName.BasicAuth:
                    page = new BasicAuthPage(Driver);
                    break;
                case ePageName.Frames:
                    page = new FramesPage(Driver);
                    break;
                case ePageName.Iframe:
                    page = new IframePage(Driver);
                    break;
                case ePageName.DynamicLoadPage:
                    page = new DynamicLoadPage(Driver);
                    break;
                case ePageName.Example2Page:
                    page = new Example2Page(Driver);
                    break;
                case ePageName.JQueryUIMenusPage:
                    page = new JQueryUIMenusPage(Driver);
                    break;
            }
            return page;
        }
    }
}
