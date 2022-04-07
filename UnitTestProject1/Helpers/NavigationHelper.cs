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
    public class NavigationHelper : HelperBase

    {
        //public IWebDriver Driver;
        private string baseURL;


        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            //this.Driver = driver;
            this.baseURL = baseURL;
        }

        public NavigationHelper OpenLoginPage()

        {
            Driver.Navigate().GoToUrl(baseURL + "/admin/");
            return this;
        }

        public NavigationHelper OpenFirstPage()

        {
            Driver.Navigate().GoToUrl("http://localhost/litecart/en/");
            return this;
        }


        public NavigationHelper OpenAppearance()
        {

            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(1) > a")).Click();
            return this;
        }

        public NavigationHelper OpenAppearanceTemplate()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(1) #doc-template")).Click();
            return this;
        }

        internal void OpenCatalogRubberDucs()
        {
            Driver.Navigate().GoToUrl("http://localhost/litecart/admin/?app=catalog&doc=catalog&category_id=1");
            //return this;
        }

        public NavigationHelper OpenAppearanceLogotype()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(1) #doc-logotype")).Click();
            return this;
        }

        public NavigationHelper OpenCatalog()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) > a")).Click();
            return this;
        }
        public NavigationHelper OpenCatalogCatalog()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-catalog")).Click();
            return this;
        }
        public NavigationHelper OpenCatalogProductGroups()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-product_groups")).Click();
            return this;
        }
        public NavigationHelper OpenCatalogOptionGroups()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-option_groups")).Click();
            return this;
        }

        public NavigationHelper OpenCatalogManufactures()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-manufacturers")).Click();
            return this;
        }

        public NavigationHelper OpenCatalogSuppliers()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-suppliers")).Click();
            return this;
        }

        public NavigationHelper OpenCatalogDeliveryStatuces()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-delivery_statuses")).Click();
            return this;
        }

        public NavigationHelper OpenCatalogSoldOutStatuces()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-sold_out_statuces")).Click();
            return this;
        }

        public NavigationHelper OpenCatalogQuantityUnits()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-quantity_units")).Click();
            return this;
        }

        public NavigationHelper OpenCatalogCSVImportExport()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(2) #doc-csv")).Click();
            return this;
        }

        public NavigationHelper OpenCountries()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(3) > a")).Click();
            return this;
        }
        public NavigationHelper OpenCurrencies()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(4) > a")).Click();
            return this;
        }
        public NavigationHelper OpenCustomers()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(5) > a")).Click();
            return this;
        }
        public NavigationHelper OpenCustomersCustomers()
        {
            Driver.FindElement(By.CssSelector(" ul#box-apps-menu #app-:nth-child(5) #doc-customers")).Click();
            return this;
        }
        public NavigationHelper OpenCustomersCSVImportExport()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(5) #doc-csv")).Click();
            return this;
        }

        public NavigationHelper OpenCustomersNewsletter()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(5) #doc-newsletter")).Click();
            return this;
        }

        public NavigationHelper OpenGeoZones()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(6) > a")).Click();
            return this;
        }
        public NavigationHelper OpenLanguages()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(7) > a")).Click();
            return this;
        }

        public NavigationHelper OpenLanguagesLanguages()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(7)  #doc-languages")).Click();
            return this;
        }

        public NavigationHelper OpenLanguagesStorageEncoder()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(7)  #doc-storage_encodings")).Click();
            return this;
        }
        public NavigationHelper OpenModules()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) > a")).Click();
            return this;
        }

        public NavigationHelper OpenModulesBacgroundJobs()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) #doc-jobs")).Click(); ;
            return this;
        }
        public NavigationHelper OpenModulesCustomer()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) #doc-customer")).Click(); ;
            return this;
        }
        public NavigationHelper OpenModulesShipping()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) #doc-shipping")).Click(); ;
            return this;
        }

        public NavigationHelper OpenModulesPayment()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) #doc-payment")).Click(); ;
            return this;
        }

        public NavigationHelper OpenModulesOrderTotal()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) #doc-order_total")).Click(); ;
            return this;
        }

        public NavigationHelper OpenModulesOrderSuccess()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) #doc-order_success")).Click(); ;
            return this;
        }

        public NavigationHelper OpenModulesOrderAction()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(8) #doc-order_action")).Click(); ;
            return this;
        }

        public NavigationHelper OpenOrders()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(9) > a")).Click(); ;
            return this;
        }

        public NavigationHelper OpenOrdersOrders()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(9) #doc-orders")).Click();
            return this;
        }

        public NavigationHelper OpenOrderStatuses()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(9)  #doc-order_statuces")).Click(); ;
            return this;
        }

        public NavigationHelper OpenPages()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(10) > a")).Click(); ;
            return this;
        }
        public NavigationHelper OpenReports()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(11) > a")).Click();
            return this;
        }

        public NavigationHelper OpenReportsMonthlySales()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(11) #doc-monthly_sales")).Click();
            return this;
        }

        public NavigationHelper OpenReportsMostSoldsProducts()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(11) #doc-most_sold_products")).Click();
            return this;
        }
        public NavigationHelper OpenReportsMostShoppingCustomers()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(11) #doc-most_shopping_customers")).Click();
            return this;
        }
        public NavigationHelper OpenSettings()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) > a")).Click();
            return this;
        }

        public NavigationHelper OpenSettingsStoreInfo()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-store_info")).Click(); ;
            return this;
        }

        public NavigationHelper OpenSettingsDefaults()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-defaults")).Click(); ;
            return this;
        }
        public NavigationHelper OpenSettingsGeneral()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-general")).Click(); ;
            return this;
        }

        public NavigationHelper OpenSettingsListings()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-listings")).Click(); ;
            return this;
        }
        public NavigationHelper OpenSettingsImages()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-checkout")).Click(); ;
            return this;
        }
        public NavigationHelper OpenSettingsCheckout()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-checkout")).Click(); ;
            return this;
        }
        public NavigationHelper OpenSettingsAdvanced()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-advanced")).Click(); ;
            return this;
        }
        public NavigationHelper OpenSettingsSecurity()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(12) #doc-security")).Click(); ;
            return this;
        }
        public NavigationHelper OpenSlides()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(13) > a")).Click();
            return this;
        }
        public NavigationHelper OpenTax()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(14) > a")).Click();
            return this;
        }
        public NavigationHelper OpenTaxClasses()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(14) #doc-tax_classes")).Click(); ;
            return this;
        }
        public NavigationHelper OpenTaxRates()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(14) #doc-tax_rates")).Click(); ;
            return this;
        }
        public NavigationHelper OpenTranslations()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(15) > a")).Click();
            return this;
        }
        public NavigationHelper OpenTranslationsSearchTranslations()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(15) #doc-search")).Click();
            return this;
        }
        public NavigationHelper OpenTranslationsScanFiles()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(15) #doc-scan")).Click();
            return this;
        }
        public NavigationHelper OpenTranslationsCSVImportExport()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(15) #doc-csv")).Click();
            return this;
        }
        public NavigationHelper OpenUsers()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(16) > a")).Click();
            return this;
        }
        public NavigationHelper OpenvQmods()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(17) > a")).Click();
            return this;
        }
        public NavigationHelper OpenvQmodsvQmods()
        {
            Driver.FindElement(By.CssSelector("ul#box-apps-menu #app-:nth-child(17) #doc-vqmods")).Click();
            return this;
        }

        public NavigationHelper OpenRubberDucksPage()
        {
            Driver.FindElement(By.CssSelector(".header [title='Catalog']")).Click();
            return this;
        }


        public NavigationHelper NewCustomerPage()
        {
            Driver.FindElement(By.XPath("//tbody/tr/td/a")).Click();
            return this;
        }
        public NavigationHelper AddNewProductPage()
        {
            Driver.FindElement(By.XPath("//a[@class = 'button'] [2]")).Click();
            return this;
        }
        public NavigationHelper AddNewProductPageGeneralTab()
        {
            Driver.FindElement(By.XPath("//a[@href = '#tab-general']")).Click();
            return this;
        }
        public NavigationHelper AddNewProductPageInformationTab()
        {
            Driver.FindElement(By.XPath("//a[@href = '#tab-information']")).Click();
            return this;
        }
        public NavigationHelper AddNewProductPageDataTab()
        {
            Driver.FindElement(By.XPath("//a[@href = '#tab-data']")).Click();
            return this;
        }


        public NavigationHelper AddNewProductPageSave()
        {
            Driver.FindElement(By.XPath("//button[@name='save']")).Click();
            return this;
        }

        public NavigationHelper ClickHomeButton()
        {
            Driver.FindElement(By.XPath("//i[@class = 'fa fa-home']")).Click();
            return this;
        }

        public NavigationHelper ClicAddNewCountryButton()
        {
            var AddNewCountryButton = Driver.FindElement(By.CssSelector(".button"));
            AddNewCountryButton.Click();
            return this;
        }

    }
}



