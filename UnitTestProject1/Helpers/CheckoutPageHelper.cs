using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Csharp_2022
{
    public class CheckOutPageHelper : HelperBase
    {
        public CheckOutPageHelper(ApplicationManager manager, string baseURL)
         : base(manager) { }
        public CheckOutPageHelper(ApplicationManager manager) : base(manager)
        {
        }

        public CheckOutPageHelper RemoveButtonClick()
        {
            var removeButtonClick = Driver.FindElement(By.Name("remove_cart_item"));
            removeButtonClick.Click();

            return this;
        }
    }
}
