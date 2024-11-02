using Tyuiu.KurbanovFA.Sprint3.Task5.V15.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать формулу, используя вложенные циклы                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите X:                                                                 ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите StartValue1:                                                       ");
            int startValue1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите StartValue2:                                                       ");
            int startValue2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите StopValue1:                                                        ");
            int stopValue1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите StopValue2:                                                        ");
            int stopValue2 = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}
