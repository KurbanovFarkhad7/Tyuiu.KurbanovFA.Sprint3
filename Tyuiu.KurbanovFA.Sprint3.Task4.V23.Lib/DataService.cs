using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double x;
            double result = 1;
            for (int i = startValue; i < stopValue; i++)
            {
                x = i;
                if (x == 0) { break; }
                double y = (Math.Cos(x) / x) + 3;
                result *= y;
            }
            return Math.Round(result,3);
        }
    }
}
