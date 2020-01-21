using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    class UnitTest4
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
