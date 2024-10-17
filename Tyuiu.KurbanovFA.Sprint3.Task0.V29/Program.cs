using Tyuiu.KurbanovFA.Sprint3.Task0.V29.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService res = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine(res.GetSumSeries(value, startValue, stopValue));
        }
    }
}
