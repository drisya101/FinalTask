using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class ManageListingsEditSteps
    {

        ManageListingsEditPage ManageListingsEditPageobj = new ManageListingsEditPage();


        [Given(@"Given The seller enters the following Shareskill data")]
        public void GivenGivenTheSellerEntersTheFollowingShareskillData(Table table)
        {
            ManageListingsEditPage details = table.CreateInstance<ManageListingsEditPage>();

            ManageListingsEditPageobj = details;
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

        [When(@"clicks on '(.*)' action button")]
        public void WhenClicksOnActionButton(string save)
        {
            ManageListingsEditPageobj.SuccessOrFailureMessage = save;
            ManageListingsEditPageobj.ManageListingsEdit();
        }


        [Then(@"Alert message ""(.*)"" is displayed")]
        public void ThenAlertMessageIsDisplayed(string expectedResult)
        {
           // Assert.AreEqual(expectedResult, ManageListingsEditPageobj.SuccessOrFailureMessage);
        }

    }
}







   






