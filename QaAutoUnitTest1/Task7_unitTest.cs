using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QaAuto;

namespace QaAutoUnitTest1
{
    [TestClass]
    public class Task7_unitTest
    {
        [TestMethod]
        [DataRow("052-8368640", true)]
        [DataRow("059-8368640", false)]
        [DataRow("152-8368640", false)]
        [DataRow("029-8368640", false)]
        [DataRow("052*8368640", false)]
        public void CorrectPhoneTest(string phone, bool res)
        {
            Task7 task7 = new Task7();
            bool funcRes = task7.checkPhoneNumber(phone);
            Assert.AreEqual(res, funcRes);
        }
    }
}
