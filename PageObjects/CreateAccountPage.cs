using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LHLO.Utilities.SeleniumUtilities;


namespace LHLO.PageObjects
{
    class CreateAccountPage : BasePage
    {
        By button = By.LinkText("Create account");

        public InformationPage ClickOnCreateAccount()
        {
            WaitForElement(driver, button);
            FindElement(driver, button).Click();
            return new InformationPage();
        }
        
    }
}
