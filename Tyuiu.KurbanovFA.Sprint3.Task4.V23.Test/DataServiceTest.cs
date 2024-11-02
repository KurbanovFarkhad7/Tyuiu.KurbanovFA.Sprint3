using Tyuiu.KurbanovFA.Sprint3.Task4.V23.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = -5; int stopValue = 5;
            double res = 0;
            res = ds.Calculate(startValue, stopValue);
            double wait = 244.656;
            Assert.AreEqual(wait, res);
        }
    }
}