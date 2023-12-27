using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusaevRS.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x == 4) && (y == 2)) || ((y == 3) && ((x == 4) || ((x >= 9) && (x <= 12)))) || ((y == 4) && ((x == 4) || ((x >= 9) && (x <= 12)))) || ((y == 5) && ((x == 4) || ((x >= 8) && (x <= 12)))) || ((y == 6) && ((x >= 3) && (x <= 13))) || ((y == 7) && ((x == 4) || ((x >= 8) && (x <= 13)))) || ((y == 8) && ((x == 4) || ((x >= 8) && (x <= 13)))) || ((y == 9) && (x >= 8) && (x <= 12)) || ((y == 10) && ((x >= 6) && (x <= 12))) || ((y == 11) && (x >= 3) && (x <= 9)) || ((y == 12) && (x >= 7) && (x <= 9)))

                res = true;
            else
                res = false;

            return res;

        }
    }
}
