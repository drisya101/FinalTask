using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class ProfileLocationSteps
    {

        ProfileLocationpages ProfileLocationpagesobj = new ProfileLocationpages();

        [Given(@"Seller updates First Name as ""(.*)""")]
        public void GivenSellerUpdatesFirstNameAs(string FirstName)
        {
            ProfileLocationpagesobj.FirstName = FirstName;
        }

        [Given(@"Seller updates Last Name as ""(.*)""")]
        public void GivenSellerUpdatesLastNameAs(string Lastname)
        {
            ProfileLocationpagesobj.LastName = Lastname;
        }

        [When(@"Clicks on Save action button")]
        public void WhenClicksOnSaveActionButton()
        {
            ProfileLocationpagesobj.UpdateProfileName();
        }

        [Then(@"Updated name ""(.*)"" should be displayed below the profile image")]
        public void ThenUpdatedNameShouldBeDisplayedBelowTheProfileImage(string expectedResult)
        {
           // Assert.AreEqual(expectedResult, ProfileLocationpagesobj.SuccessOrFailureMessage);
        }

        [Given(@"Seller Select Availability as ""(.*)""")]
        public void GivenSellerSelectAvailabilityAs(string availability)
        {
            ProfileLocationpagesobj.Availability = availability;
            ProfileLocationpagesobj.UpdateAvailability();
        }

        [Then(@"Availability should be updated\. The alert message,""(.*)"" will be displayed on top right of the application\.")]
        public void ThenAvailabilityShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string expectedResult)
        {
            Assert.AreEqual(expectedResult, ProfileLocationpagesobj.SuccessOrFailureMessage);
        }

        [Given(@"seller Select Hours as ""(.*)""")]
        public void GivenSellerSelectHoursAs(string hours)
        {
            ProfileLocationpagesobj.Hours = hours;
            ProfileLocationpagesobj.UpdateHours();
        }

        [Then(@"Hours should be updated\. The alert message,""(.*)"" will be displayed on top right of the application\.")]
        public void ThenHoursShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string expectedResult)
        {
            Assert.AreEqual(expectedResult, ProfileLocationpagesobj.SuccessOrFailureMessage);
        }

        [Given(@"seller Select Earn Target as""(.*)""")]
        public void GivenSellerSelectEarnTargetAs(string earntarget)
        {
            ProfileLocationpagesobj.EarnTarget = earntarget;
            ProfileLocationpagesobj.UpdateEarnTarget();
        }

        [Then(@"Earn Target should be updated\. The alert message,""(.*)"" will be displayed on top right of the application\.")]
        public void ThenEarnTargetShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string expectedResult)
        {
            Assert.AreEqual(expectedResult, ProfileLocationpagesobj.SuccessOrFailureMessage);
        }

    }
}
