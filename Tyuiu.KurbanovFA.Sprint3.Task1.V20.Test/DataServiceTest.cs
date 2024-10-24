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
            int startValue = 1; int stopValue = 16;
            double res = 0;
            res = ds.GetSumSeries(startValue, stopValue);
            double wait = 51191.405;
            Assert.AreEqual(wait, res);
        }
    }
}