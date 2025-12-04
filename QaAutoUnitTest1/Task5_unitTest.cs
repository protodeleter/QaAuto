using Microsoft.VisualStudio.TestTools.UnitTesting;
using QaAuto;
using System;

namespace QaAutoUnitTest1
{
    [TestClass]
    public class Task5_unitTest
    {
        [TestMethod]
        [DataRow(15651515, 123, false)]
        [DataRow(15651513, 123, true)]
        public void TestMethod1( int a, int b, bool res )
        {

            Task5 task5 = new Task5();

            bool resFunc = task5.brothers(a, b);

            Assert.AreEqual(res, resFunc);


        }
    }
}
