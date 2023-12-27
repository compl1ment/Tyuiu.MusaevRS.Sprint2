using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusaevRS.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                    if (n == 31)
                        res = "1 февраля " + g + " года";
                    if (n > 30)
                        res = "В январе не может быть больше 31 дня";
                    else
                        res = (n + 1) + " января " + g + "года";
                    break;
                case 2:
                    if (n == 29)
                        res = "1 марта " + g + " года";
                    if (n > 29)
                        res = "В феврале не может быть больше 29 дней";
                    else
                        res = (n + 1) + " февраля " + g + " года";
                    break;
                case 3:
                    if (n == 31)
                        res = "1 апреля " + g + " года";
                    if (n > 31)
                        res = "В марте не может быть больше 31 дня";
                    else
                        res = (n + 1) + " марта " + g + " года";
                    break;
                case 4:
                    if (n == 30)
                        res = "1 мая " + g + " года";
                    if (n > 30)
                        res = "В апреле не может быть больше 30 дней";
                    else
                        res = (n + 1) + " апреля " + g + " года";
                    break;
                case 5:
                    if (n == 31)
                        res = "1 июня " + g + " года";
                    if (n > 31)
                        res = "В мае не может быть больше 31 дня";
                    else
                        res = (n + 1) + " мая " + g + " года";
                    break;
                case 6:
                    if (n == 30)
                        res = "1 июля " + g + " года";
                    if (n > 30)
                        res = "В июне не может быть больше 30 дней";
                    else
                        res = (n + 1) + " июня " + g + " года";
                    break;
                case 7:
                    if (n == 31)
                        res = "1 августа " + g + " года";
                    if (n > 31)
                        res = "В июле не может быть больше 31 дня";
                    else
                        res = (n + 1) + " июля " + g + " года";
                    break;
                case 8:
                    if (n == 31)
                        res = "1 сентября " + g + " года";
                    if (n > 31)
                        res = "В августе не может быть больше 31 дня";
                    else
                        res = (n + 1) + " августа " + g + " года";
                    break;
                case 9:
                    if (n == 30)
                        res = "1 октября " + g + " года";
                    if (n > 30)
                        res = "В сентябре не может быть больше 30 дней";
                    else
                        res = (n + 1) + " сентября " + g + " года";
                    break;
                case 10:
                    if (n == 31)
                        res = "1 ноября " + g + " года";
                    if (n > 31)
                        res = "В октябре не может быть больше 31 дня";
                    else
                        res = (n + 1) + " октября " + g + " года";
                    break;
                case 11:
                    if (n == 30)
                        res = "1 декабря " + g + " года";
                    if (n > 30)
                        res = "В ноябре не может быть больше 30 дней";
                    else
                        res = (n + 1) + " ноября" + g + " года";
                    break;
                case 12:
                    if (n == 31)
                        res = "1 января " + (g + 1) + " года";
                    if (n > 31)
                        res = "В декабре не может быть больше 31 дня";
                    else
                        res = (n + 1) + " декабря " + g + " года";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
            return res;

        }
    }
}
