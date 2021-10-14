using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using WpfAppWithDll;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number1 = 1;
            int number2 = 1;

            string expected = "True";
            MainWindow c = new MainWindow();
            string actual = c.Equals_Click(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int number1 = 1;
            int number2 = 1;

            string expected = "2";
            MainWindow c = new MainWindow();
            string actual = c.Summ_Click(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int number1 = 3;
            int number2 = 1;

            string expected = "False";
            MainWindow c = new MainWindow();
            string actual = c.Equals_Click(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int number1 = 3;
            int number2 = 1;

            string expected = "4";
            MainWindow c = new MainWindow();
            string actual = c.Summ_Click(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }



}
