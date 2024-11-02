using Tyuiu.KurbanovFA.Sprint3.Task5.V15.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1; int startValue1 = 1; int startValue2 = 1; int stopValue1 = 1; int stopValue2 = 1;
            double res = 0;
            res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 244.656;
            Assert.AreEqual(wait, res);
        }
    }
}