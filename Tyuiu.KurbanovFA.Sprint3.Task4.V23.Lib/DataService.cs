using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double x = 0;
            double y = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                y += (Math.Cos(x) / x) + 3;
                if (x == 0){break;} else { continue;}
            }
            return Math.Round(y,3);
        }
    }
}
