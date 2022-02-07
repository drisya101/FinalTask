using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class Driver
    {
        
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
           
            driver = new ChromeDriver();
            TurnOnWait();

            driver.Manage().Window.Maximize();
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }



        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

      
        public void Close()
        {
            driver.Quit();
        }

        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }

        [Obsolete]
        public static IWebElement WaitForElement(By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }
    }
}
