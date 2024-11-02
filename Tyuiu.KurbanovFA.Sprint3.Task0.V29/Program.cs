using Tyuiu.KurbanovFA.Sprint3.Task0.V29.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();            

            Console.Title = "Спринт #3 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
            Console.WriteLine("* по формуле, при t=0,5   (Картинка с формулой)                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите Value:                                                             ");
            double value = double.Parse(Console.ReadLine());
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
            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
