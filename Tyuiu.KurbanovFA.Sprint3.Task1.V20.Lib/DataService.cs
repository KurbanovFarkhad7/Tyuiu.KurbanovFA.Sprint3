using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 0;
            startValue = 1;
            stopValue = 16;
            while (startValue <= stopValue)
            {
                startValue++;
                result += Math.Pow(1 / Math.Cos(startValue), 2);
            }
            return Math.Round(result, 3);
        }
    }
}
