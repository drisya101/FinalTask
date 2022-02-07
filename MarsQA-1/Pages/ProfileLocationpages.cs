using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfileLocationpages
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Availability { get; set; }
        public string Hours { get; set; }
        public string EarnTarget { get; set; }
        public string SuccessOrFailureMessage { get; set; }

        private static IWebElement NameArrowicon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
        private static IWebElement FirstnameTab => Driver.driver.FindElement(By.Name("firstName"));
        private static IWebElement LastnameTab => Driver.driver.FindElement(By.Name("lastName"));
        private static IWebElement Saveaction => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
        private static IWebElement Avilabilitypenicon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private static IWebElement Avilabilityselectarrow => Driver.driver.FindElement(By.Name("availabiltyType"));
        private static IWebElement Hourspenicon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private static IWebElement Hoursselectarrow => Driver.driver.FindElement(By.Name("availabiltyHour"));
        private static IWebElement EarnTargetpenicon => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        private static IWebElement EarnTargetselectarrow => Driver.driver.FindElement(By.Name("availabiltyTarget"));
        private static IWebElement titleElement => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));

        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";


        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));


        public void UpdateProfileName()
        {

            NameArrowicon.Click();
            FirstnameTab.Clear();
            FirstnameTab.SendKeys(FirstName);
            LastnameTab.Clear();
            LastnameTab.SendKeys(LastName);
            Saveaction.Click();

            Thread.Sleep(1000);


        }

        public void UpdateAvailability()
        {
                       
            Avilabilitypenicon.Click();

            var selectElement = new SelectElement(Avilabilityselectarrow);

            selectElement.SelectByText(Availability);
           
            Thread.Sleep(2000);
            SuccessOrFailureMessage = PopUpMessage.Text;

        }

        public void UpdateHours()
        {

            Hourspenicon.Click();
            var HourselectElement = new SelectElement(Hoursselectarrow);

            HourselectElement.SelectByText(Hours);

            Thread.Sleep(2000);
            SuccessOrFailureMessage = PopUpMessage.Text;

        }

        public void UpdateEarnTarget()
        {
            EarnTargetpenicon.Click();          
            var EarnTargetSlectElement = new SelectElement(EarnTargetselectarrow);
            EarnTargetSlectElement.SelectByText(EarnTarget);
            Thread.Sleep(2000);
            SuccessOrFailureMessage = PopUpMessage.Text;

        }

    }
}
