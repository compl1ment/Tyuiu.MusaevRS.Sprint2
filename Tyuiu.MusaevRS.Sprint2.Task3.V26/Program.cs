using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint2.Task3.V26.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task3.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double res;
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №26                                                             *");
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
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            res = ds.Calculate(x);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
