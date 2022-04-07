using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Csharp_2022
{
    public class ProductPageHelper : HelperBase
    {
        public ProductPageHelper(ApplicationManager manager, string baseURL)
         : base(manager) { }
        public ProductPageHelper(ApplicationManager manager) : base(manager)
        {
        }



        public ProductPageHelper AddToCardButtonClick()
        {
            var elementPresent = true;
            try
            {
                IWebElement sizeDropDown = Driver.FindElement(By.Name("options[Size]"));
                sizeDropDown.Click();
                sizeDropDown.SendKeys("s");
                sizeDropDown.SendKeys(Keys.Enter);
            }
            catch (NoSuchElementException sizeDropDownDisplayed)
            {
               elementPresent = false; ;

            }
            finally
            {
                var addToCardButton = Driver.FindElement(By.XPath("//button[@name ='add_cart_product']"));
                addToCardButton.Click();
            }


            //if ( Driver.FindElement(By.Name("options[Size]")).    Displayed)
            //{
            //    var sizeDropDown = Driver.FindElement(By.Name("options[Size]"));
            //    sizeDropDown.SendKeys("s");
            //    sizeDropDown.SendKeys(Keys.Enter);
            //}

            //else
            //{
            //   var addToCardButton = Driver.FindElement(By.XPath("//button[@name ='add_cart_product']"));
            //   addToCardButton.Click();
            //}

            return this;
        }


        public ProductPageHelper ProductQuantityVerification(WebDriverWait wait, string i)
        {
            wait.Until(ExpectedConditions.TextToBePresentInElement(Driver.FindElement(By.CssSelector("span.quantity")), i));
            return this;
            //var productQuantity2 = Driver.FindElement(By.CssSelector("span.quantity"));
            //productQuantity2.GetAttribute("textContant");
            //wait.Until(ExpectedConditions.TextToBePresentInElement(productQuantity2, "2"));
        }
        public ProductPageHelper CheckoutClick()
        {
            Driver.Navigate().GoToUrl("http://localhost/litecart/en/checkout");

            return this;
        }
    }
}