using Tyuiu.KurbanovFA.Sprint3.Task4.V23.Lib;

namespace Tyuiu.KurbanovFA.Sprint3.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить              *");
            Console.WriteLine("* значение функции y=(cos(x)/x)+3 При х = 0 прервать цикл.                *");
            Console.WriteLine("* Полученные значения перемножать.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите startValue:                                                        ");
            int startValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите stopValue:                                                         ");
            int stopValue = int.Parse(Console.ReadLine());
            Console.WriteLine("* startValue = " + startValue);
            Console.WriteLine("* stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(startValue, stopValue));
        }
    }
}
