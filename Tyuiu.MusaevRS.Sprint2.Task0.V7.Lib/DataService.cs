﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusaevRS.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x != y;
            res[1] = x == y;
            res[2] = (y - x) == 372;
            res[3] = y > x;
            res[4] = (x + 372) == y;
            res[5] = x > y;

            return res;

        }
    }
}
