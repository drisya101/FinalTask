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
    class ManageListingsEditPage
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Tags { get; set; }
        public string Enddate { get; set; }
        public string ServiceType { get; set; }
        public string LocationType { get; set; }
        public string Availabledays { get; set; }
        public string SkillTrade { get; set; }
        public string SkillExchange { get; set; }
        public string WorkSamples { get; set; }
        public string Active { get; set; }
        public string SuccessOrFailureMessage { get; set; }
        public string Credit { get; set; }
        






        private static IWebElement ManageListingsaction => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Manage Listings']"));
        private static IWebElement Editicon => Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        private static IWebElement titletext => Driver.driver.FindElement(By.Name("title"));
        private static IWebElement descriptiontext => Driver.driver.FindElement(By.Name("description"));
        private static IWebElement Categorytext => Driver.driver.FindElement(By.Name("categoryId"));
        private static IWebElement Subcategorytext => Driver.driver.FindElement(By.Name("subcategoryId"));
        private static IWebElement Tagstext => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        private static IWebElement ServiceTypetext => Driver.driver.FindElement(By.XPath("//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']"));
        private static IWebElement ServiceTypeOptions => Driver.driver.FindElement(By.XPath("//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']"));
        private static IWebElement Hourlybasisservicetype => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        private static IWebElement HourlybasisservicetypeLabel => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/label"));
        private static IWebElement Oneoffservicetype => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        private static IWebElement OneoffservicetypeLabel => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/label"));
        private static IWebElement LocationTypeOption => Driver.driver.FindElement(By.XPath("//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        private static IWebElement Onsitetype => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
        private static IWebElement OnsitetypeLabel => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/label"));
        private static IWebElement Onlinetype => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        private static IWebElement OnlineLabel => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/label"));
        private static IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Share Skill']"));
        private static IWebElement StartDateDropDown => Driver.driver.FindElement(By.Name("startDate"));
        private static IWebElement EndDateDropDown => Driver.driver.FindElement(By.Name("endDate"));
        private static IWebElement Days => Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]"));
        private static IWebElement StartTime => Driver.driver.FindElement(By.XPath("//div[3]/div[2]/input[1]"));
        private static IWebElement EndTime => Driver.driver.FindElement(By.XPath("//div[3]/div[3]/input[1]"));
        private static IWebElement CheckboxForDays => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
        private static IWebElement SaturDay => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[1]/div/input"));
        private static IWebElement SkillTradeOption => Driver.driver.FindElement(By.XPath("//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        private static IWebElement Skillexchangetype => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        private static IWebElement SkillExchangeLabel => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/label"));
        private static IWebElement CreditAmounttextbox => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
        private static IWebElement CredittypeText => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        private static IWebElement CreditLabell => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/label"));
        private static IWebElement SkillExchangeTag => Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));
        private static IWebElement ActiveOption => Driver.driver.FindElement(By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        private static IWebElement Activetype => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
        private static IWebElement ActiveLabel => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/label"));
        private static IWebElement Hiddentype => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
        private static IWebElement HiddenLabel => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/label"));
        private static IWebElement WorkSampleFileUpload => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private static IWebElement Save => Driver.driver.FindElement(By.XPath("//input[@value='Save']"));


        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";
      
        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));



        public void ManageListingsEdit()
        {

     
            ManageListingsaction.Click();

            Editicon.Click();

            titletext.Clear();
            titletext.SendKeys(Title);

           
            descriptiontext.Clear();
            descriptiontext.SendKeys(Description);

            var selectElement1 = new SelectElement(Categorytext);
    
            selectElement1.SelectByText(Category);


           
            var SelectElement2 = new SelectElement(Subcategorytext);

            SelectElement2.SelectByText(SubCategory);


            Tagstext.SendKeys(Tags);
            Tagstext.SendKeys(Keys.Enter);

           

            string Locationtype = (LocationType);
            if (Locationtype.Equals(OnsitetypeLabel.Text))
            {
                Onsitetype.Click();

            }
            else if (Locationtype.Equals(OnlineLabel.Text))
            {
                Onlinetype.Click();
            }


            CheckboxForDays.Click();


   
            string Skilltrade = (SkillTrade);

            if (Skilltrade.Equals(SkillExchangeLabel.Text))
            {
                Skillexchangetype.Click();

            }
            else if (Skilltrade.Equals(CreditLabell.Text))
            {
                CredittypeText.Click();
            }

   

            CreditAmounttextbox.SendKeys(Credit);
           

            string active = (Active);


            if (active.Equals(ActiveLabel.Text))
            {
                Activetype.Click();

            }
            else if (active.Equals(HiddenLabel.Text))
            {
                Hiddentype.Click();
            }
            Save.Click();

            
            Thread.Sleep(2000);
           


        }










































    }
}
