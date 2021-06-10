using CapitolisTestProject;
using NLog;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.IO;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        private IWebDriver driver;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory + @"\Drivers\");
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void test_checkbox()
        {
            logger.Info("Starting checkboxes test!");

            MainPage mainPage = new MainPage(driver);
            try
            {
                mainPage.openMainPage(MainPage.eCredentials.WithoutCredentials);
                logger.Info("entered Main page");
            }
            catch
            {
                logger.Error("Error with entering to the main page");
            }
            Thread.Sleep(2000);

            try
            {
                CheckBoxesPage checkBoxesPage = mainPage.goToCheckBoxesPage();
                Thread.Sleep(6000);

                checkBoxesPage.pressOnCheckbox(CheckBoxesPage.eCheckBox.First);
                Thread.Sleep(2000);
                checkBoxesPage.pressOnCheckbox(CheckBoxesPage.eCheckBox.Second);
                logger.Info("TEST PASSED!{0}", Environment.NewLine);
            }
            catch
            {
                logger.Error("Error with entering to the CheckBoxes page");
            }


            Thread.Sleep(6000);
        }

        [Test]
        public void test_auth()
        {
            logger.Info("Starting basic auth test!");

            MainPage mainPage = new MainPage(driver);
            try
            {
                mainPage.openMainPage(MainPage.eCredentials.WithCredentials);
                logger.Info("entered Main page");
            }
            catch
            {
                logger.Error("Error with entering to the main page");
            }
            Thread.Sleep(2000);

            try
            {
                BasicAuthPage basicAuthPage = mainPage.goToCBasicAuthPage();
                basicAuthPage.isTestPassed();
                logger.Info("TEST PASSED!{0}", Environment.NewLine);
            }
            catch
            {
                logger.Error("Error with entering to the basic auth page");
            }

            Thread.Sleep(6000);

        }

        [Test]
        public void test_frames()
        {
            logger.Info("Starting frames test!");

            MainPage mainPage = new MainPage(driver);
            try
            {
                mainPage.openMainPage(MainPage.eCredentials.WithoutCredentials);
                logger.Info("entered Main page");
            }
            catch
            {
                logger.Error("Error with entering to the main page");
            }
            Thread.Sleep(3000);

            try
            {
                FramesPage framePage = mainPage.goToCFramePage();
                Thread.Sleep(3000);
                logger.Info("entered frame page");
                IframePage iFramePage = framePage.goToIframePage();
                Thread.Sleep(3000);
                iFramePage.enterText();
                Thread.Sleep(3000);
                logger.Info("TEST PASSED!{0}", Environment.NewLine);
            }
            catch
            {
                logger.Error("Error with entering to the frame page");
            }
        }

        [Test]
        public void test_dynamic()
        {
            logger.Info("Starting dynamics test!");

            MainPage mainPage = new MainPage(driver);
            try
            {
                mainPage.openMainPage(MainPage.eCredentials.WithoutCredentials);
                logger.Info("entered Main page");
            }
            catch
            {
                logger.Error("Error with entering to the main page");
            }
            Thread.Sleep(6000);

            try
            {
                DynamicLoadPage dynamicLoadPage = mainPage.goToDynamicLoadPage();
                Thread.Sleep(6000);
                logger.Info("Entered to the dynamic load page");

                Example2Page example2Page = dynamicLoadPage.goToExample2Page();
                Thread.Sleep(6000);

                example2Page.clickSStartButtonAndEnsureHelloWorldAppear();
                Thread.Sleep(6000);
                logger.Info("TEST PASSED!{0}", Environment.NewLine);
            }
            catch
            {
                logger.Error("Error with entering to the dynamic load page");
            }


            //Log test passed
        }

        [Test]
        public void test_jquery()
        {
            logger.Info("Starting jquery test!");

            MainPage mainPage = new MainPage(driver);
            try
            {
                mainPage.openMainPage(MainPage.eCredentials.WithoutCredentials);
                logger.Info("entered Main page");
            }
            catch
            {
                logger.Error("Error with entering to the main page");
            }
            Thread.Sleep(6000);

            try
            {
                JQueryUIMenusPage jQueryUIMenusPage = mainPage.goToJQueryUIMenusPage();
                logger.Info("entered jquery ui menu page");
                Thread.Sleep(6000);

                jQueryUIMenusPage.pressOnExcelDownload();
                logger.Info("TEST PASSED!{0}", Environment.NewLine);
            }
            catch
            {
                logger.Error("Error with entering to the jquery ui menu page");
            }
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}