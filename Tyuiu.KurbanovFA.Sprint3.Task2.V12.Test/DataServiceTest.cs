using Tyuiu.KurbanovFA.Sprint3.Task2.V12.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 1; int startValue = 1; int stopValue = 16;
            double res = 0;
            res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 51191.405;
            Assert.AreEqual(wait, res);
        }
    }
}