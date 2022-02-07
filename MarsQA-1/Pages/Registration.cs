using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Registration
    {
        public string Joinbutton { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailaddress { get; set; }
        public string password { get; set; }
        public string Confirmpassword { get; set; }
        public string Termsandconditions { get; set; }
        public string Join { get; set; }
        public string SuccessOrFailureMessage { get; set; }

        // Join Page web elements
        private static IWebElement Joinaction => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));
        private static IWebElement FirstnameTab => Driver.driver.FindElement(By.Name("firstName"));
        private static IWebElement LastnameTab => Driver.driver.FindElement(By.Name("lastName"));
        private static IWebElement EmailTab => Driver.driver.FindElement(By.Name("email"));
        private static IWebElement PasswordTab => Driver.driver.FindElement(By.Name("password"));
        private static IWebElement ConfirmpasswordTab => Driver.driver.FindElement(By.Name("confirmPassword"));
        private static IWebElement TandC => Driver.driver.FindElement(By.Name("terms"));
        private static IWebElement JoinTab => Driver.driver.FindElement(By.XPath("//*[@id='submit-btn']"));
        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";

        //common
       //private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));


        public void Newaccount()
        {            
            Driver.driver.FindElement(By.XPath("//button[normalize-space()='Sign Out']")).Click();
            Joinaction.Click();
            FirstnameTab.SendKeys(Firstname);
            LastnameTab.SendKeys(Lastname);
            EmailTab.SendKeys(Emailaddress);
            PasswordTab.SendKeys(password);
            ConfirmpasswordTab.SendKeys(Confirmpassword);
            TandC.Click();
            JoinTab.Click();
            Thread.Sleep(2000);
           //SuccessOrFailureMessage = PopUpMessage.Text;

         }
    }
}
