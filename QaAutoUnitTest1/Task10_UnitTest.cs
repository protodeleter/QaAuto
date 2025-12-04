using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QaAuto;
using System.ComponentModel;
namespace QaAutoUnitTest1
{
    [TestClass]
    public class Task10_UnitTest
    {
        [TestMethod]
        [DataRow(5, true)]
        [DataRow(4, false)]
        public void TestMethod_isPrime(int num , bool res)
        {
            Task10 task10 = new Task10();
            bool funkRes = task10.isPrime(num);
            Assert.AreEqual(res, funkRes);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 3, 5, 7, 11, 13, 17 } , true, DisplayName="All prime") ]
        [DataRow(new int[] { 4, 6, 8, 9, 10, 12, 14, 15, 16 } , false, DisplayName = "All not prime")]
        [DataRow(new int[] {} , false, DisplayName = "Empty array")]
        [DataRow(null , false, DisplayName = "Null instead of array")]

        public void TestMethod_ChkIfArrIsPrime( int[] arr , bool res)
        {

            Task10 task10 = new Task10();
            bool funkRes = task10.ChkIfArrIsPrime(arr);
            Assert.AreEqual(res, funkRes);

        }
    }
}
