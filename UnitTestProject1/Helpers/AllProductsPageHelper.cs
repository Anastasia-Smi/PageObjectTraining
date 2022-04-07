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
    public class AllProductsPageHelper : HelperBase
    {
        public AllProductsPageHelper(ApplicationManager manager, string baseURL)
         : base(manager) { }
        public AllProductsPageHelper(ApplicationManager manager) : base(manager)
        {
        }


        public AllProductsPageHelper SelectTheFirstProduct()
        {
            var firstProduct = Driver.FindElement
                (By.XPath("(//li[@class='product column shadow hover-light'])[1]"));
            firstProduct.Click();

            return this;
        }
    }
}
