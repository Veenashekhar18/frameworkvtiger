using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.ProductsRepo
{
    internal class Homepage
    {
        public string url = "http://localhost:8888/index.php?action=index&module=Home";
        [FindsBy(How = How.XPath, Using = "//input[@name='user_name']")]
        public IWebElement usernametxt;
        [FindsBy(How=How.XPath,Using = "//input[@name='user_password']")]
        public IWebElement passwordtxt;
        [FindsBy(How = How.Id, Using = "submitButton")]
        public IWebElement loginbtn;
        [FindsBy(How=How.XPath,Using = "//a[.='Products']")]
        public IWebElement productslink;
        [FindsBy(How=How.XPath,Using = "//img[@title='Create Product...']")]
        public IWebElement createproductbtn;

        public Homepage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void username()
        {
            usernametxt.SendKeys("admin");
        }

        public void password()
        {
            passwordtxt.SendKeys("password");
        }

        public void Login()
        {
            loginbtn.Click();
        }
    }
}
