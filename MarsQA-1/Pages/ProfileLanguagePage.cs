using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    public class ProfileLanguagePage
    {
 
        public string Language { get; set; }
        public string Level { get; set; }
        public string LanguageMessage { get; set; }

    
        private static IWebElement LanguageTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private static IWebElement AddNewActionButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement LanguageTextField => Driver.driver.FindElement(By.Name("name"));
        private static IWebElement LevelSelectElement => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement AddActionButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";

        private static IWebElement SucessOrFailure => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        public void AddLanguage()
        {
  
            LanguageTab.Click();


            AddNewActionButton.Click();

              
            LanguageTextField.SendKeys(Language);



            var selectElement = new SelectElement(LevelSelectElement);

            // select by text
            selectElement.SelectByText(Level);


            AddActionButton.Click();

            Thread.Sleep(2000);



            LanguageMessage = SucessOrFailure.Text;

        }



        public void UpdateLanguage()
        {


            IWebElement EditButtonPen = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditButtonPen.Click();

     
            IWebElement UpdateButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));


            LanguageTextField.Clear();
            LanguageTextField.SendKeys(Language);

            var selectElement = new SelectElement(LevelSelectElement);

            selectElement.SelectByText(Level);

            UpdateButton.Click();


            Thread.Sleep(2000);

            LanguageMessage = SucessOrFailure.Text;

        }

        public void DeleteLanguage()
        {

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();


            Thread.Sleep(2000);

            LanguageMessage = SucessOrFailure.Text;

        }
    } 
}
                        