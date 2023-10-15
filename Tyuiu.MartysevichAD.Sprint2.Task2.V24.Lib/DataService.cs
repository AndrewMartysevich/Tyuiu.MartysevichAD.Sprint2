using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MartysevichAD.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }           
            if ((x >= 3) && (x <= 5) && (y >= 8) && (y <= 10))
            {
                res = false;
            }
            if ((x >= 6) && (x <= 8) && (y >= 3) && (y <= 4))
            {
                res = false;
            }
            if ((x >= 9) && (x <= 12) && (y >= 7) && (y <= 8))
            {
                res = false;
            }
            if ((x >= 8) && (x <= 10) && (y >= 11) && (y <= 12))
            {
                res = false;
            }
            if ((x >= 3) && (x <= 6) && (y == 12))
            {
                res = false;
            }
            if ((x == 13)&& (y != 6))
            {
                res = false;
            }
            return res;
        }
    }
}
