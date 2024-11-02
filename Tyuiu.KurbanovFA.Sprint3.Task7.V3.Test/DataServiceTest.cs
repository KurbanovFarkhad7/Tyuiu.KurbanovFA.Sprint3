using Tyuiu.KurbanovFA.Sprint3.Task7.V3.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = 1; int stopValue = 1;
            double[] res = { 4.34, 4.16 };
            double[] wait = { 4.34, 4.16 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}