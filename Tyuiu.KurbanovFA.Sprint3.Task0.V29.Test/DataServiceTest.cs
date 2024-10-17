using Tyuiu.KurbanovFA.Sprint3.Task0.V29.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5; int startValue = 1; int stopValue = 10;
            double res = 0;
            res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2.065;
            Assert.AreEqual(wait, res);
        }
    }
}