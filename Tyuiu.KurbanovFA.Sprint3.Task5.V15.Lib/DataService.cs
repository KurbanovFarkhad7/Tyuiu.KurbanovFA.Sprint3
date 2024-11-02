using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task5.V15.Lib
{
    public class DataService : ISprint3Task5V15
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            /*x = 5; startValue1 = 1; startValue2 = 1; stopValue1 = 3; stopValue2 = 10;*/
            double result1 = 0;
            double result2 = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++, startValue2++)
                {
                    result1 += Math.Sin(x) + (Math.Pow(startValue2, 2) / 2);
                }
                result2 += result1;
            }
            return Math.Round(result2, 3);
        }
    }
}
