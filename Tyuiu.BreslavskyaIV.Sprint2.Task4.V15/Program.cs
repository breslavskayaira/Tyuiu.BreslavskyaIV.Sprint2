using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BreslavskyaIV.Sprint2.Task4.V15.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint2.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Бреславская И. В. | ПКТб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Тернарный оператор                                                 *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнила: Бреславская И. В. | ПКТб-23-2                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение переменной z    *");
            Console.WriteLine("* по введенным пользователем значениям переменных X и Y.                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");




            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            double res = ds.Calculate(x, y);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Значение переменной = " + res);


            Console.ReadKey();
        }
    }
}
