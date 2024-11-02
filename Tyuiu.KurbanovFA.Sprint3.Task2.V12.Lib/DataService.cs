using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double ro;

            do
            {
                ro = Math.Pow(300 / (startValue + Math.Pow(5, startValue)), startValue);
                startValue++;
            }
            while (startValue <= stopValue);
            return ro;
        }
    }
}
