using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static MarsQA_1.SpecflowPages.Pages.ManageRequests;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class ManageRequestSteps
    {
        ManageRequests ManageRequestsobj = new ManageRequests();
        ISet<RecievedRequest> recievedRequestsInPage;

        [Given(@"the user has received the following requests")]
        public void GivenTheUserHasReceivedTheFollowingRequests(Table table)
        {
            IEnumerable Requests = table.CreateSet<ManageRequests>();
            
        }

        [When(@"the user clicks ""(.*)"" link under Manage Requests tab")]
        [Obsolete]
        public void WhenTheUserClicksLinkUnderManageRequestsTab(string managerequests)
        {

            recievedRequestsInPage = ManageRequestsobj.ReceivedRequests();
        }

        [Then(@"the Received Requests list page is displayed with the following data")]
        public void ThenTheReceivedRequestsListPageIsDisplayedWithTheFollowingData(Table table)
        {
            table.CompareToSet<RecievedRequest>(recievedRequestsInPage);
        }



    }
}
