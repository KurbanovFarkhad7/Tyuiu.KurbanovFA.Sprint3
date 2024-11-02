using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KurbanovFA.Sprint3.Task7.V3.Lib
{
    public class DataService : ISprint3Task7V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] results = new double[11];
            for (int i = 0; i <= 10; i++)
            {
                double x = -5 + i;
                double result = CalculateFunction(x);
                results[i] = Math.Round(result, 2);
            }
            return results;
        }

        static double CalculateFunction(double x)
        {
            if (Math.Sin(x) - 3 + x == 0)
            {
                return 0;
            }

            return ((3 * x - 1.5) / (Math.Sin(x) - 3 + x)) + 2;
        }
    }
}
