using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint2.Task2.V13.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            bool res;
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание №2                                                              *");
            Console.WriteLine("* Вариант №13                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет находится ли точка в области      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Область с точками                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите x:                                                              *");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите y:                                                              *");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
