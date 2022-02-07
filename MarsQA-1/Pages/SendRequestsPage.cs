using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class SendRequestsPage
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Recipient { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Actions { get; set; }
        public string SuccessOrFailureMessage { get; set; }
        public ISet<SentRequests> SENTREQUESTS { get; set; }

        private static IWebElement ManageRequestLink => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[1]"));
        private static IWebElement selectSentRequest => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Sent Requests']"));


        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";
        //common
        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        [Obsolete]
        public ISet<SentRequests> SENTRequests()
        {
            ManageRequestLink.Click();

            SENTREQUESTS = new HashSet<SentRequests>();
            Driver.WaitForElement(By.XPath("//a[normalize-space()='Sent Requests']"), 30);
            selectSentRequest.Click();
            // xpath of html table
            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[2]/div[1]/table"));

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    SentRequests SEntRequest = new SentRequests();
                    SEntRequest.Category = lstTdElem[0].Text;
                    SEntRequest.Title = lstTdElem[1].Text;
                    SEntRequest.Message = lstTdElem[2].Text;
                    SEntRequest.Recipient = lstTdElem[3].Text;
                    SEntRequest.Status = lstTdElem[4].Text;
                    SEntRequest.Type = lstTdElem[5].Text;
                    SEntRequest.Date = lstTdElem[6].Text;
                    SENTREQUESTS.Add(SEntRequest);
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }

            return SENTREQUESTS;
        }

        public class SentRequests
        {
            public string Category { get; set; }
            public string Title { get; set; }
            public string Message { get; set; }
            public string Recipient { get; set; }
            public string Status { get; set; }
            public string Type { get; set; }
            public string Date { get; set; }
        }

    }
}

