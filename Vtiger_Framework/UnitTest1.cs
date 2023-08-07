using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vtiger_Framework
{
    [TestClass]
    [TestCategory("multiple test initialise")]
    public class UnitTest1 
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Teh test method is executed");
        }
        [TestMethod]
        public void TestMethod2() { Console.WriteLine("The 2nd test method is executed"); }
       
    }
}
