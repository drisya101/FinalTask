using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static MarsQA_1.SpecflowPages.Pages.SendRequestsPage;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class SendRequestsSteps
    {
        SendRequestsPage SentRequestsPageobj = new SendRequestsPage();
        ISet<SentRequests> SentRequestsInPage;

        [Given(@"User has Sent the following requests")]
        public void GivenUserHasSentTheFollowingRequests(Table table)
        {
            IEnumerable Sent = table.CreateSet<SendRequestsPage>();
        }

        [When(@"User clicks ""(.*)"" link under Manage Requests tab")]
        [Obsolete]
        public void WhenUserClicksLinkUnderManageRequestsTab(string p0)
        {
            SentRequestsInPage = SentRequestsPageobj.SENTRequests();
        }
        [Then(@"User Sent Requests list Page is displayed with the following data")]
        public void ThenUserSentRequestsListPageIsDisplayedWithTheFollowingData(Table table)
        {
            table.CompareToSet<SentRequests>(SentRequestsInPage);
        }


    }
}
