﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(5, 5);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, 4);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(3, 3);
        }
    }
}
