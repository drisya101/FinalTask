using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ManageRequests
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Sender { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Actions { get; set; }
        public string SuccessOrFailureMessage { get; set; }
        public ISet<RecievedRequest> recievedRequests { get; set; }
       
        private static IWebElement ManageRequestLink => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[1]"));
        private static IWebElement ReceivedRequest => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Received Requests']"));
        private static IWebElement ActionsLIst => Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/thead/tr/th[8]"));
        
        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";

        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        [Obsolete]
        public ISet<RecievedRequest> ReceivedRequests()
        {


            ManageRequestLink.Click();

            recievedRequests = new HashSet<RecievedRequest>();

            Driver.WaitForElement(By.XPath("//a[normalize-space()='Received Requests']"), 30);
            ReceivedRequest.Click();


            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table"));


            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            foreach (var elemTr in lstTrElem)
            {

                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    RecievedRequest recievedRequest = new RecievedRequest();
                    recievedRequest.Category = lstTdElem[0].Text;
                    recievedRequest.Title = lstTdElem[1].Text;
                    recievedRequest.Message = lstTdElem[2].Text;
                    recievedRequest.Sender = lstTdElem[3].Text;
                    recievedRequest.Status = lstTdElem[4].Text;
                    recievedRequest.Type = lstTdElem[5].Text;
                    recievedRequest.Date = lstTdElem[6].Text;
                    recievedRequests.Add(recievedRequest);
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }

            return recievedRequests;
        }



        public class RecievedRequest
        {
            public string Category { get; set; }
            public string Title { get; set; }
            public string Message { get; set; }
            public string Sender { get; set; }
            public string Status { get; set; }
            public string Type { get; set; }
            public string Date { get; set; }
        }
    }  
            
}












































