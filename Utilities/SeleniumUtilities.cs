using LHLO.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHLO.Utilities
{
    class SeleniumUtilities : TestBase
    {
        public static IWebElement FindElement(IWebDriver driver, By by)
        {
            return driver.FindElement(by);
        }

        public static void WaitForElement(IWebDriver driver, By by)
        {
            WebDriverWait Wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }
    }
}
