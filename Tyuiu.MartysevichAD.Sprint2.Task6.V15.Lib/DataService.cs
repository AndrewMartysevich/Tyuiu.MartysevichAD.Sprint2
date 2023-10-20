using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MartysevichAD.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int value)
        {
            int res = 0;
            if(value % 7 >= 1 & value % 7 < 2)
            {
                res += 1;
            }
            if (value % 7 >= 2 & value % 7 < 3)
            {
                res += 2;
            }
            if (value % 7 >= 3 & value % 7 < 4)
            {
                res += 3;
            }
            if (value % 7 >= 4 & value % 7 < 5)
            {
                res += 4;
            }
            if (value % 7 >= 5 & value % 7 < 6)
            {
                res += 5;
            }
            if (value % 7 >= 6 & value % 7 < 7)
            {
                res += 6;
            }
            if (value % 7 >= 7)
            {
                res += 7;
            }

            switch (res)
            {
                case 1:return "Понедельник";

                case 2:return "Вторник";

                case 3:return "Среда";

                case 4:return "Четверг";

                case 5:return "Пятница";

                case 6:return "Суббота";

                case 7:return "Воскресенье";

                default:
                    throw new ArgumentException($"Значение дня должно быть не больше 365. Значение {value}");
            }
        }
    }
}
