using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JenkinsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace JenkinsTest.Tests
{
    [TestClass()]
    public class OperationTestTests
    {
        OperationTest oper = new OperationTest();
        [TestMethod()]
        public void addTest()
        {
            Assert.AreEqual(3, oper.add(1, 2));
        }

        [TestMethod()]
        public void subTest()
        {
            Assert.AreEqual(1, oper.sub(3, 1));
        }
    }
}
