using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {

        public static string Url = "http://localhost:5000";

        public static string projectrootdir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

        public static string ScreenshotPath = projectrootdir + "\\TestReports\\Screenshots\\";


        public static string ReportsPath = "";

        public static string ExcelPath = projectrootdir + "\\SpecflowTests\\Data\\Mars.xlsx";


    }
}