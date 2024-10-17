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
            double value = 0; int startValue = 0; int stopValue = 0;
            double res = 0;
            res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}