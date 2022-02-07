using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class ShareskillSteps
    {

        ShareskillPage ShareskillPageobj = new ShareskillPage();

        [Given(@"The seller enters the following Shareskill data")]
        public void GivenTheSellerEntersTheFollowingShareskillData(Table table)
        {
            ShareskillPage details = table.CreateInstance<ShareskillPage>();

            ShareskillPageobj = details;
            Console.WriteLine(details.Title);
            Console.WriteLine(details.Description);
            Console.WriteLine(details.Category);
            Console.WriteLine(details.SubCategory);
            Console.WriteLine(details.Tags);
            Console.WriteLine(details.ServiceType);
            Console.WriteLine(details.LocationType);
            Console.WriteLine(details.Availabledays);
            Console.WriteLine(details.SkillTrade);
            Console.WriteLine(details.SkillExchange);
            Console.WriteLine(details.WorkSamples);
            Console.WriteLine(details.Active);

        }                          
        
        
        [When(@"clicks on ""(.*)"" action button")]
        public void WhenClicksOnActionButton(string save)
        {
            ShareskillPageobj.EnterShareSkill();
        }
        
        [Then(@"Alert message ""(.*)"" is displayed on top right of the application\.")]
        public void ThenAlertMessageIsDisplayedOnTopRightOfTheApplication_(string expectedResult)
        {
            //Assert.AreEqual(expectedResult, ShareskillPageobj.SuccessOrFailureMessage);
        }

    }
}

