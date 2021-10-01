using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LHLO.Utilities.SeleniumUtilities;


namespace LHLO.PageObjects
{
    class InformationPage : BasePage
    {
        By registerButton = By.LinkText("Go to Register");

        public RegisterPage ClickOnGoToRegisterButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(20, document.body.scrollHeight)");
            FindElement(driver, registerButton).Click();
            return new RegisterPage();

        }
    }
}
