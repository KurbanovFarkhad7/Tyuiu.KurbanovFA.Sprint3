using Tyuiu.KurbanovFA.Sprint3.Task1.V20.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 1; int startValue = 1; int stopValue = 10;
            double res = 0;
            res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 2.065;
            Assert.AreEqual(wait, res);
        }
    }
}