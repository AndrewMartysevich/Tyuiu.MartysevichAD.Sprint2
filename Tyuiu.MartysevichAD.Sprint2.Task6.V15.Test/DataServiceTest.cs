using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint2.Task6.V15.Lib;

namespace Tyuiu.MartysevichAD.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1));
        }
    }
}
