using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint2.Task4.V11.Lib;

namespace Tyuiu.MartysevichAD.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 228.719;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -160;
            double res = ds.Calculate(x, y);
            double wait = 0.013;
            Assert.AreEqual(wait, res);
        }
    }
}
