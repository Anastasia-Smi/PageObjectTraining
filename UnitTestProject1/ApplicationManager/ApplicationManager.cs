using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Selenium_Csharp_2022
{
    public class ApplicationManager
    {
        public IWebDriver Driver { get; }
        //private IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper Navigator { get; }
        protected ProductPageHelper ProductPage { get; }
        protected AllProductsPageHelper AllProductsPage { get; }
        protected CheckOutPageHelper CheckoutPage { get; }

        public ThreadLocal<ApplicationManager> appThread = new ThreadLocal<ApplicationManager>();

        /// <summary>
        /// Class constructor
        /// </summary>
        public ApplicationManager()
        {

            Driver = new ChromeDriver();
            baseURL = "http://localhost/litecart";
            ProductPage = new ProductPageHelper(this);
            loginHelper = new LoginHelper(this);
            Navigator = new NavigationHelper(this, baseURL);
            AllProductsPage = new AllProductsPageHelper(this);
        }

        /// <summary>
        /// Class Destructor
        /// </summary>
        ~ApplicationManager()
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public ApplicationManager GetInstance()
        {
            if (!appThread.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigator.OpenLoginPage();
                appThread.Value = newInstance;
            }
            return appThread.Value;
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

    }
}