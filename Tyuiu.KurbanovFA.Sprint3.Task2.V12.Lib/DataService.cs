using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            /*startValue = 1;
            stopValue = 5;
            value = 5;*/

            double ro = 1;

            do
            {
                ro *= Math.Pow(300 / (startValue + Math.Pow(value, startValue)), startValue);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(ro, 3);
        }
    }
}
