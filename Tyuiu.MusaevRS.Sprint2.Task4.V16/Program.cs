using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint2.Task4.V16.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            double res;
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                               *");
            Console.WriteLine("* Задание №4                                                              *");
            Console.WriteLine("* Вариант №16                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите x:                                                              *");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите y:                                                              *");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            res = ds.Calculate(x, y);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
