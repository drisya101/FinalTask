using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class ManageListingsDeleteSteps
    {

        ManageListingsDelete ManageListingsDeleteobj = new ManageListingsDelete();
        [When(@"clicks on deleteaction button")]
        public void WhenClicksOnDeleteactionButton()
        {
            ManageListingsDeleteobj.ManageListingsdelete();
        }
        [Then(@"popup message ""(.*)"" is displayed")]
        public void ThenPopupMessageIsDisplayed(string expectedResult)
        {
           // Assert.AreEqual(expectedResult, ManageListingsDeleteobj.SuccessOrFailureMessage);
        }

    }



}

