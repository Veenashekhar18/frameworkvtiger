using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.GenericUtility;
using Vtiger_Framework.Main_Folder.ObjectRepository.LoginRepo;

namespace Vtiger_Framework.Test_Scripts.Test.LoginTest
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        [TestMethod]
        [Owner("Datta")]
        public  void login()
        {
            extentReports.CreateTest(test_context.TestName);
            LoginPage login = new LoginPage(driver);
            login.Login();


        }
    }
}
