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
    class ChangePasswordPage
    {
       public string ChangePassword { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string Confirmpassword { get; set; }
        public string SuccessOrFailureMessage { get; set; }

        private static IWebElement HiUserTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        private readonly By ChangePasswordSelector = By.XPath("//a[normalize-space()='Change Password']");
        private static IWebElement ChangePasswordButton => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Change Password']"));
        private static IWebElement Currentpasswordtext => Driver.driver.FindElement(By.Name("oldPassword"));
        private static IWebElement NewpasswordText => Driver.driver.FindElement(By.Name("newPassword"));
        private static IWebElement ConfirmpasswordText => Driver.driver.FindElement(By.Name("confirmPassword"));

        public void Changepassword()
        {

            HiUserTab.Click();

            Driver.WaitForElement(ChangePasswordSelector, 30);
            ChangePasswordButton.Click();

            Thread.Sleep(2000);         
            Currentpasswordtext.SendKeys(CurrentPassword);
      
            NewpasswordText.SendKeys(NewPassword);      
            ConfirmpasswordText.SendKeys(Confirmpassword);

            Thread.Sleep(2000);
        }

    }
}
