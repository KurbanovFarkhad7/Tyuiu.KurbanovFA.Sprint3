using Tyuiu.KurbanovFA.Sprint3.Task2.V12.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при х=5                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите Value:                                                             ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите startValue:                                                        ");
            int startValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите stopValue:                                                         ");
            int stopValue = int.Parse(Console.ReadLine());
            Console.WriteLine("* startValue = " + startValue);
            Console.WriteLine("* stopValue = " + stopValue);
            Console.WriteLine("* value = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
