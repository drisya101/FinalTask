using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class ChangePasswordSteps
    {

        ChangePasswordPage ChangePasswordPage = new ChangePasswordPage();
        

        [Given(@"seller enter current password  as ""(.*)""")]
        public void GivenSellerEnterCurrentPasswordAs(string currentpassword)
        {
            ChangePasswordPage.CurrentPassword = currentpassword;
        }

        [Given(@"seller enter New Password as ""(.*)""")]
        public void GivenSellerEnterNewPasswordAs(string newpassword)
        {
            ChangePasswordPage.NewPassword = newpassword;
        }
        [Given(@"seller enter Confirm Password as ""(.*)""")]
        public void GivenSellerEnterConfirmPasswordAs(string confirmpassword)
        {
                ChangePasswordPage.Confirmpassword = confirmpassword;
          
        }

        [When(@"Clicks on Saveaction button")]
        public void WhenClicksOnSaveactionButton()
        {
            ChangePasswordPage.Changepassword();
        }

        [Then(@"change password should be updated\.The alert message,""(.*)"" will be displayed")]
        public void ThenChangePasswordShouldBeUpdated_TheAlertMessageWillBeDisplayed(string expectedResult)
        {
            // Assert.AreEqual(expectedResult, Changepasswordpageobj.SuccessOrFailureMessage);
        }
    }
}

