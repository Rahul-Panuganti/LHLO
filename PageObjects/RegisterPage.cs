using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LHLO.Utilities.SeleniumUtilities;


namespace LHLO.PageObjects
{
    class RegisterPage : BasePage
    {
        By firstName = By.Id("FirstName");
        By familyName = By.Id("LastName");
        By email = By.Id("Email");
        By ConfirmEmail = By.Id("ConfirmEmail");
        By dateOfBirthDay = By.Id("DateOfBirth_Day");
        By dateOfBirthMonth = By.Id("DateOfBirth_Month");
        By dateOfBirthYear = By.Id("DateOfBirth_Year");
        By mobilePhone = By.Id("MobilePhone");
        By alternativePhone = By.Id("AlternativePhone");
        By nextButton = By.CssSelector("input[name='btnSubmit']");
        
        public void FillAllMandatoryFeilds(String first_Name, String family_Name, String fill_email,
            String Confirm_Email, String dateOfBirth_Day, String dateOfBirth_Month, String dateOfBirth_Year, 
            String mobile_Phone, String alternative_Phone)
        {
            FindElement(driver, firstName).SendKeys(first_Name);
            FindElement(driver, familyName).SendKeys(family_Name);
            FindElement(driver, email).SendKeys(fill_email);
            FindElement(driver, ConfirmEmail).SendKeys(Confirm_Email);
            FindElement(driver, dateOfBirthDay).SendKeys(dateOfBirth_Day);
            FindElement(driver, dateOfBirthMonth).SendKeys(dateOfBirth_Month);
            FindElement(driver, dateOfBirthYear).SendKeys(dateOfBirth_Year);
            FindElement(driver, mobilePhone).SendKeys(mobile_Phone);
            FindElement(driver, alternativePhone).SendKeys(alternative_Phone);
        }

        public SecondRegisterPage ClickOnNext()
        {
            WaitForElement(driver, nextButton);
            FindElement(driver, nextButton).Click();
            return new SecondRegisterPage();
        }

    }
}
