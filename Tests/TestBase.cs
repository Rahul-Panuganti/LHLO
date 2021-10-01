using LHLO.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHLO.Tests
{
    class TestBase
    {
        public static IWebDriver driver;
        public CreateAccountPage createAccountPage;
        public InformationPage informationPage;
        public RegisterPage registerPage;
        public SecondRegisterPage secondRegisterPage;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            String ApplicationUrl = ConfigurationManager.AppSettings["url"];
            driver.Url = ApplicationUrl;

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        /*  [TearDown]
          public void TearDown()
          {
              TakeScreenShotOnFailure();
              driver.Quit();
          }*/
    }
}
