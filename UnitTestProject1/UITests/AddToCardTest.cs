using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Selenium_Csharp_2022;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;


namespace Selenium_Csharp_2022
{


    [TestClass]
    public class AddingNewProductToCard : ApplicationManager
    {
        [TestMethod]
        [Description("TASK_13_Verification of Adding a New products to Card")]
        [TestCategory("Regression")]
        [Priority(9)]
        //1) открыть главную страницу
        //2) открыть первый товар из списка
        //2) добавить его в корзину(при этом может случайно добавиться товар, который там уже есть, ничего страшного)
        //3) подождать, пока счётчик товаров в корзине обновится
        //4) вернуться на главную страницу, повторить предыдущие шаги ещё два раза, чтобы в общей сложности в корзине было 3 единицы товара
        //5) открыть корзину(в правом верхнем углу кликнуть по ссылке Checkout)
        //6) удалить все товары из корзины один за другим, после каждого удаления подождать, пока внизу обновится таблица
        public void AddingNewProductToCardTest()
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            Driver.Manage().Window.Maximize();

            Navigator.OpenLoginPage();
            loginHelper.LogIn();

            Navigator.OpenRubberDucksPage();

            AllProductsPage.SelectTheFirstProduct();
            ProductPage.AddToCardButtonClick();

            ProductPage.ProductQuantityVerification(wait, "1");

            Navigator.ClickHomeButton();
            AllProductsPage.SelectTheFirstProduct();
            ProductPage.AddToCardButtonClick();

            ProductPage.ProductQuantityVerification(wait, "2");

            Navigator.ClickHomeButton();
            AllProductsPage.SelectTheFirstProduct();
            ProductPage.AddToCardButtonClick();

            ProductPage.ProductQuantityVerification(wait, "3");

            ProductPage.CheckoutClick();


            ReadOnlyCollection<IWebElement> products = Driver.FindElements(By.XPath
            ("//li [@class = 'item']"));

            ReadOnlyCollection<IWebElement> buttons = Driver.FindElements(By.XPath
            ("//p/button [@name = 'remove_cart_item']"));

            ReadOnlyCollection<IWebElement> productsInTabs = Driver.FindElements(By.XPath
           ("//td [@class = 'item']"));

            List<string> deleteButtons = new List<string>();
            List<IWebElement> productsList = new List<IWebElement>();
            List<string> productsTable = new List<string>();



            foreach (var product in products)

            {
                var currentProductTest = wait.Until(ExpectedConditions.ElementToBeClickable
                    (product.FindElement(By.XPath(".//form[@name = 'cart_form']"))));

                productsList.Add(currentProductTest);
            }

            foreach (var webElement in productsList)
            {

                var currentProduct = wait.Until(ExpectedConditions.ElementToBeClickable
                 (webElement));

                do
                {
                    var delButton = wait.Until(ExpectedConditions.ElementToBeClickable
                    (webElement.FindElement(By.XPath(".//div/p/button [@value = 'Remove']"))));
                    delButton.Click();
                    wait.Until(ExpectedConditions.StalenessOf(currentProduct));
                }
                while (products.Count<1);

                
            };
        }
    }
}