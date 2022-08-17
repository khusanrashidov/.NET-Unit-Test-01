using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTestForArrays
    {
        [TestMethod]
        public void TestMethodForArrays()
        {
            double[] array;
            array = new double[9];
            array[8] = 8;
            var testInstance = new Program();
            var instanceResult = testInstance.ReturnTrue(array);
            Assert.IsTrue(instanceResult);
        }
    }
}
