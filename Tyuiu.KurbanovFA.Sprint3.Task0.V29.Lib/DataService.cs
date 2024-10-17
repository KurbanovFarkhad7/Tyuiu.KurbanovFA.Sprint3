using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            stopValue = 10;
            for (startValue = 1; startValue < stopValue; startValue++)
            {
                value = (Math.Pow(0.5, 2 * startValue) +  (1 / startValue + 1)) * Math.Cos(0.5);
            }
            return value;

        }
    }
}
