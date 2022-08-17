using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodTrue()
        {
            var testInstance = new Class();
            var testResult = testInstance.IsUrFavColorPurple("purple");
            Assert.IsTrue(testResult);
            var anotherTestInstance = new Class();
            var anotherTestResult = anotherTestInstance.IsUrFavColorGreen("green");
            Assert.AreEqual(true, anotherTestResult, "should be greeen to be true");
        }
        [TestMethod]
        public void TestMethodFalse()
        {
            var testInstance = new Class();
            var testResult = testInstance.IsUrFavColorGray("purple");
            Assert.IsFalse(testResult);
        }

    }
}