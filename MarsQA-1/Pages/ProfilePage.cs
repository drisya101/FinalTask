using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    public class ProfilePage
    {
  
        public IWebElement Chaticon => Driver.driver.FindElement(By.XPath("/html//div[@id='account-profile-section']/div/div[1]//a[@href='/Home/Message']"));
        public IWebElement ChatSearch => Driver.driver.FindElement(By.XPath("/html//div[@id='chatRoomContainer']/div[@class='chatRoom']//input[@class='prompt']"));
        public IWebElement Chatname => Driver.driver.FindElement(By.XPath("/html//div[@id='chatList']/div[1]/div[@class='content']/div[@class='header']"));
        public IWebElement Chattextbox => Driver.driver.FindElement(By.XPath("/html//input[@id='chatTextBox']"));
        public IWebElement chatsendtab => Driver.driver.FindElement(By.XPath("/html//button[@id='btnSend']"));
        public IWebElement ProfTab => Driver.driver.FindElement(By.LinkText("Profile"));

        #region Chat in profile

        public void ClickProTab()

        {

            ProfTab.Click();
        }

        public void Chat()
        {
            Chaticon.WaitForElementClickable(Driver.driver, 60);
            Chaticon.Click();
        }
        public void Chatsearch()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Thread.Sleep(2000);
            ChatSearch.Click();
            ChatSearch.SendKeys(ExcelLibHelper.ReadData(2, "ChatSearch"));
        }

        public void ChatsearchVisible()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Thread.Sleep(2000);
            String Searchtxt = Driver.driver.FindElement(By.XPath("//div[normalize-space()='sampath3']")).Text; ;
            Assert.AreEqual(Searchtxt, ExcelLibHelper.ReadData(2, "ChatSearch"));

        }
        public void ChatMessage()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            Thread.Sleep(2000);
            Chattextbox.Click();
            Chattextbox.SendKeys(ExcelLibHelper.ReadData(2, "ChatTextBox"));

        }
        public void ChatSendbtn()
        {
            chatsendtab.Click();

        }

        #endregion

        #region Validate Chat


        #endregion
    }
}


    

