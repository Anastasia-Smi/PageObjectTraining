using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Csharp_2022;
using NUnit.Framework;



namespace Selenium_Csharp_2022
{
    public class BaseTest : ApplicationManager
    {
        public static bool PERFORM_LONG_UI_CHECKS = true;
        protected ApplicationManager app;

        [SetUp]
        public void SetupApplicationManager()
        {
            //app = ApplicationManager.GetInstance();
        }
    }

}