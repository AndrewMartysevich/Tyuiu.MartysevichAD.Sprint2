using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint2.Task6.V15.Lib;

namespace Tyuiu.MartysevichAD.Sprint2.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Получение результата из switch                                   *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Дано целое число k (1 <= k <= 365). Определить, каким днем недели     *");
            Console.WriteLine("*  является k-й день не високосного года, в котором 1 января понедельник.*");                                                                              
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите число ");
            int value = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((value < 1) || (value > 365))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = ds.FindDayName(value);
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
