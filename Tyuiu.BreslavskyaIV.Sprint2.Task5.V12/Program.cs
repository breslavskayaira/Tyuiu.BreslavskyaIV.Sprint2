using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskyaIV.Sprint2.Task5.V12.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint2.Task5.V12

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                    *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год), *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m            *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год является високосным.       *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");




            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();      
            string  res = ds.FindDateOfPreviousDay(g, m, n);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Дата предыдущего дня:" + res);


            Console.ReadKey();
        }
    }
}
