using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfAppWithDll;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange 
            MainWindow c = new MainWindow();
            double arg1 = 4;
            double arg2 = 2;
            double expected = 2;
            // act
             
            string result = c.Equals_Click(arg1, arg2);
            // assert            
            Assert.AreEqual(expected, result);
        }
    }
}
