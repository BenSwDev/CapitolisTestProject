using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapitolisTestProject
{
    public class CheckBoxesPage : Page
    {
        private readonly string firstCheckBoxElement = @"#checkboxes > input[type=checkbox]:nth-child(1)";
        private readonly string secondCheckBoxElement = @"#checkboxes > input[type=checkbox]:nth-child(3)";
        public enum eCheckBox
        {
            First,
            Second
        }

        public CheckBoxesPage(IWebDriver driver) : base(driver) { }

        public void pressOnCheckbox(eCheckBox first)
        {
            string elementAddress = first == eCheckBox.First ? firstCheckBoxElement : secondCheckBoxElement;
            IWebElement checkBox = Driver.FindElement(By.CssSelector(elementAddress));
            string enable = checkBox.Selected ? "Enable" : "Disable";
            logger.Info("The check box is" + enable);

            try
            {
                checkBox.Click();
                enable = checkBox.Selected ? "Enable" : "Disable";
                logger.Info("Check Box was clicked");
                logger.Info("The checkbox is" + enable);
            }
            catch
            {
                logger.Error("Check Box was NOT clicked");
            }
        }

    }
}
