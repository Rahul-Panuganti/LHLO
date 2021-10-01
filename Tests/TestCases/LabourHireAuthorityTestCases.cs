using LHLO.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHLO.Tests.TestCases
{
    class LabourHireAuthorityTestCases : TestBase
    {
        [Test]
        public void CreateAccountButtonTest()
        {
            /* Create Account Button will be clicked*/
            createAccountPage = new CreateAccountPage();

            /*Will take to the next information page*/
            informationPage = createAccountPage.ClickOnCreateAccount();

        }

        [Test]
        public void GoToRegisterButtonTest()
        {
            /* Create Account Button will be clicked*/
            createAccountPage = new CreateAccountPage();

            /*Will take to the next information page*/
            informationPage = createAccountPage.ClickOnCreateAccount();

            /*will take you to the registration page*/
            informationPage.ClickOnGoToRegisterButton();
        }

        [Test]
        public void FirstRegistrationPageTest()
        {
            /*passing the customer details*/
            String first_Name = "John";
            String family_Name = "Mabute";
            String fill_email = "testing90000@testing.com";
            String Confirm_Email = "testing90000@testing.com";
            String dateOfBirth_Day = "22";
            String dateOfBirth_Month = "05";
            String dateOfBirth_Year = "1995";
            String mobile_Phone = "12345678";
            String alternative_Phone = "12345678";

            /* Create Account Button will be clicked*/
            createAccountPage = new CreateAccountPage();

            /*Will take to the next information page*/
            informationPage = createAccountPage.ClickOnCreateAccount();

            /*will take you to the registration page*/
            registerPage = informationPage.ClickOnGoToRegisterButton();

            /*fill all mandatory details*/
            registerPage.FillAllMandatoryFeilds(first_Name, family_Name, fill_email, Confirm_Email,
             dateOfBirth_Day, dateOfBirth_Month, dateOfBirth_Year, mobile_Phone, alternative_Phone);
           
            /*click the next button*/
            registerPage.ClickOnNext();
        }
    }
}
