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
    internal class EditProductPage
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Products']")]
        public IWebElement productslink;

    }
}
