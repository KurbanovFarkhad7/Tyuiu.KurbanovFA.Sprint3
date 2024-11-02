using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double S = 0;
            double result = 1;
            for (startValue = startValue;  startValue <= stopValue; startValue++)
            {
                result += (Math.Pow(value, 2 * startValue) + (1 / (startValue + 1))) * Math.Cos(value);
                /*result = result + S * 7.06;*/
                
            }
            return Math.Round(result, 3);

        }
    }
}
