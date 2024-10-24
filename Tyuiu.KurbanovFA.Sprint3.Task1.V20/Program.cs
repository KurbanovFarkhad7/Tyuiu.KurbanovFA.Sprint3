using Tyuiu.KurbanovFA.Sprint3.Task1.V20.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
            Console.WriteLine("* по формуле, при t=0,5   (Картинка с формулой)                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите Value:                                                             ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите startValue:                                                        ");
            int startValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите stopValue:                                                         ");
            int stopValue = int.Parse(Console.ReadLine());
            Console.WriteLine("* value = " + value);
            Console.WriteLine("* startValue = " + startValue);
            Console.WriteLine("* stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
