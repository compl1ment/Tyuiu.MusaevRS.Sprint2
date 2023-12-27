using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusaevRS.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + b < c) || (c < b);
            res[1] = (a + d < c) && (c < b);
            res[2] = (a > d) || (c < b);
            res[3] = (d + c == 668) && (c < b);
            res[4] = (b > d) && (c < b);
            res[5] = (d > b) || (c > a);

            return res;


        }
    }
}
