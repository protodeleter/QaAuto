using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskSix;
using System;


namespace QaAutoUnitTest1
{
    [TestClass]

    public class Task6_unitTest
    {
        [TestMethod]
        [DataRow(24, true)]
        [DataRow(25, false)]
        public void Task6_method(int numb , bool res)
        {
            Task_6 task6 = new Task_6();
            bool runres = task6.perfectNumber(numb);
            Assert.AreEqual(res, runres);

        }
    }
}
