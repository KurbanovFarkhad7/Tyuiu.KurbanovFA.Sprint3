using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task5.V15.Lib
{
    public class DataService : ISprint3Task5V15
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double result = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (i = startValue2; i < stopValue2; i++)
                {
                    result += Math.Sin(x) + (Math.Pow(startValue2, 2) / 2);
                }
            }
            return result;
        }
    }
}
