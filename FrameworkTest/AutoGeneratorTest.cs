using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace FrameworkTest
{
    [TestClass]
    public class AutoGeneratorTest
    {
        [TestMethod]
        public void TestGetRandomNumberType()
        {
            var nextNumber = AutoGenerator.GetRandomNumber();
            Assert.IsInstanceOfType(nextNumber, typeof(int));            
        }

        [TestMethod]
        public void TestGetRandomNumberNotZero()
        {
            var nextNumber = AutoGenerator.GetRandomNumber();
            Assert.AreNotEqual(nextNumber, 0);
        }

        [TestMethod]
        public void TestGetRandomNumberSmallerThen15()
        {
            var nextNumber = AutoGenerator.GetRandomNumber();
            Assert.IsTrue(nextNumber < 15);
        }
    }
}
