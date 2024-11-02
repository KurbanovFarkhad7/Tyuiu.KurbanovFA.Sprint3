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
            int value = 5; int startValue = 1; int stopValue = 5;
            double res = 0;
            res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.033;
            Assert.AreEqual(wait, res);
        }
    }
}