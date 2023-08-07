using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.ProductsRepo
{
    internal class CreateProduct
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Products']")]
        public IWebElement productslink;
        [FindsBy(How = How.XPath, Using = "//img[@title='Create Product...']")]
        public IWebElement createproductbtn;
        [FindsBy(How=How.Name,Using = "productname")]
        public IWebElement productnametxt;
        [FindsBy(How = How.XPath, Using = "//select[@name='productcategory']")]
        public IWebElement productcategorydropdown;
        [FindsBy(How=How.Id,Using = "qtyinstock")]
        public IWebElement quantitytxt;
        [FindsBy(How=How.XPath,Using = "//input[@title='Save [Alt+S]']")]
        public IWebElement savebtn;
        [FindsBy(How=How.XPath,Using = "//input[@title='Cancel [Alt+X]']")]
        public IWebElement cancelbtn;

        public CreateProduct(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void Productlink()
        {
            productslink.Click();
        }

        public void Createproduct()
        {
            createproductbtn.Click();
        }

        public void Productname()
        {
            productnametxt.SendKeys("dgshss");
        }

        public void Productcategory()
        {
            
            productcategorydropdown.Click();
        }

        public void Quantity()
        {
            quantitytxt.SendKeys("12");
        }

        public void Save()
        {
            savebtn.Click();
        }
    }
}
