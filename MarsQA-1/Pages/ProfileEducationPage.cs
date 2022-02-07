using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfileEducationPage
    {
        public string UniversityName { get; set; }
        public string Country { get; set; }
        public string Title { get; set; }
        public string Degree{ get; set; }
        public int YearOfGraduation { get; set; }
        public string EducationMessage { get; set; }

        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement UniversityNameField => Driver.driver.FindElement(By.Name("instituteName"));
        private static IWebElement CountryOfUni => Driver.driver.FindElement(By.Name("country"));
        private static IWebElement TitleFromDropDown => Driver.driver.FindElement(By.Name("title"));
        private static IWebElement DegreeTextFieldBox => Driver.driver.FindElement(By.Name("degree"));
        private static IWebElement GraduationYear => Driver.driver.FindElement(By.Name("yearOfGraduation"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));

        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";
        private static IWebElement AlertBoxMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        public void AddEducation() {
          
           EducationTab.Click();

           AddNewButton.Click();

            UniversityNameField.SendKeys(UniversityName);           


           var countryselectElement = new SelectElement(CountryOfUni);

           countryselectElement.SelectByText(Country);

           var titleselectElement = new SelectElement(TitleFromDropDown);

           titleselectElement.SelectByText(Title);

            DegreeTextFieldBox.SendKeys(Degree);

           var graduationyearselectElement = new SelectElement(GraduationYear);

           graduationyearselectElement.SelectByText(YearOfGraduation.ToString());
            
           AddButton.Click();


            Thread.Sleep(2000);

            EducationMessage = AlertBoxMessage.Text;
           
        }


  
           public  void UpdateEducation()
        {
            EducationTab.Click();

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")).Click();

            var selectElement = new SelectElement(CountryOfUni);

            selectElement.SelectByText(Country);


            var university = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            UniversityNameField.Clear();
            UniversityNameField.SendKeys(UniversityName);


            var titleselectElement = new SelectElement(TitleFromDropDown);

            titleselectElement.SelectByText(Title);

            DegreeTextFieldBox.Clear();
            DegreeTextFieldBox.SendKeys(Degree);

     

            var graduationyearselectElement = new SelectElement(GraduationYear);

            graduationyearselectElement.SelectByText(YearOfGraduation.ToString());


            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();



            Thread.Sleep(2000);

            EducationMessage = AlertBoxMessage.Text;

            }
       
 

        public  void DeleteEducation() {
            
            EducationTab.Click();


            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")).Click();

    

            Thread.Sleep(2000);

            EducationMessage = AlertBoxMessage.Text;
        }
    }
}
