using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double S = 0;
           /* double value = 0.5;
            int startValue = 1;
            int stopValue = 10;*/
            for (int i = startValue; i < stopValue + 1; i++)
            {
                S = (Math.Pow(value, 2 * startValue) +  (1 / startValue + 1)) * Math.Cos(value);
            }
            return S;

        }
    }
}
