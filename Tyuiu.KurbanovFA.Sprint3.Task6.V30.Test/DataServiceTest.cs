using Tyuiu.KurbanovFA.Sprint3.Task6.V30.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = 11; int stopValue = 17;
            double res = 0;
            res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 548.732;
            Assert.AreEqual(wait, res);
        }
    }
}