using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageListingsDelete
    {
       
        public string SuccessOrFailureMessage { get; set; }

        private static IWebElement ManageListingsaction => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Manage Listings']"));
        private static IWebElement Deleteicon => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
        
        private static IWebElement YES => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));

        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";
    
        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        public void ManageListingsdelete()
        {
            ManageListingsaction.Click();
            Deleteicon.Click();
            
                    
            YES.Click();
       
        }
    }
}
