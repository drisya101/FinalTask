using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class ProfileChatSteps
    {
        ProfilePage page = new ProfilePage();

        [Given(@"User is on Profile Tab")]
        public void GivenUserIsOnProfileTab()
        {
            page.ClickProTab();
        }

        [Given(@"the user Clicks on Chat tab Chat screen opens")]
        public void GivenTheUserClicksOnChatTabChatScreenOpens()
        {
            page.Chat();
        }

        [When(@"the user inputs name in search input box")]
        public void WhenTheUserInputsNameInSearchInputBox()
        {
            page.Chatsearch();
        }


        [Then(@"Chats between the input name and user should be visible")]
        public void ThenChatsBetweenTheInputNameAndUserShouldBeVisible()
        {
            page.ChatsearchVisible();
        }

        [Then(@"to send message add message in input box")]
        public void ThenToSendMessageAddMessageInInputBox()
        {
            page.ChatMessage();
        }

        [Then(@"Clicks on send button")]
        public void ThenClicksOnSendButton()
        {
            page.ChatSendbtn();
        }

    }
}
