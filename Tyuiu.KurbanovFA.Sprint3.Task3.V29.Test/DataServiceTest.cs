using Tyuiu.KurbanovFA.Sprint3.Task3.V29.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "chgr vhhtg hnht"; char item = 'h';
            string res;
            res = ds.DeleteCharInString(value, item);
            string wait = "cgr vtg nt";
            Assert.AreEqual(wait, res);
        }
    }
}