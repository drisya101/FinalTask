using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class RegistrationSteps
    {



        Registration Registrationobj = new Registration();

       [Given(@"the first name  is ""(.*)""")]
        public void GivenTheFirstNameIs(string firstname)
        {
            Registrationobj.Firstname = firstname;
        }
        
        [Given(@"the last name is ""(.*)""")]
        public void GivenTheLastNameIs(string lastname)
        {
            Registrationobj.Lastname = lastname;
        }
        
        [Given(@"the Emali address is ""(.*)""")]
        public void GivenTheEmaliAddressIs(string Email)
        {
            Registrationobj.Emailaddress = Email;
        }
        
        [Given(@"the password is ""(.*)""")]
        public void GivenThePasswordIs(string password)
        {
            Registrationobj.password = password;
        }
        
        [Given(@"the Confirm password is ""(.*)""")]
        public void GivenTheConfirmPasswordIs(string confirmpassword)
        {
            Registrationobj.Confirmpassword = confirmpassword;
        }

        [Given(@"the user check on I agree to the terms and conditions")]
        public void GivenTheUserCheckOnIAgreeToTheTermsAndConditions()
        {
            // Do nothing
        }


        [When(@"the user cliks on join")]
        public void WhenTheUserCliksOnJoin()
        {
            Registrationobj.Newaccount();
        }
        
        [Then(@"the user acoout should be created, the alert message ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenTheUserAcooutShouldBeCreatedTheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string expectedResult)
        {
           // Assert.AreEqual(expectedResult, Registrationobj.SuccessOrFailureMessage);
        }
    }
}
