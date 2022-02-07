﻿using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    
        public class CommonMethods
        {


            public class SaveScreenShotClass
            {

                public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
                {
                    var folderLocation = (ConstantHelpers.ScreenshotPath);

                    if (!System.IO.Directory.Exists(folderLocation))
                    {
                        System.IO.Directory.CreateDirectory(folderLocation);
                    }

                    var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                    var fileName = new StringBuilder(folderLocation);

                    fileName.Append(ScreenShotFileName);
                    fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                    fileName.Append(".jpeg");
                    screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                    return fileName.ToString();
                }
            }


        #region reports
        public static string ReportPath;
        public static string ReportXMLPath;
        public static ExtentTest test;
        public static ExtentReports extent;


        #endregion
        




    }







}

