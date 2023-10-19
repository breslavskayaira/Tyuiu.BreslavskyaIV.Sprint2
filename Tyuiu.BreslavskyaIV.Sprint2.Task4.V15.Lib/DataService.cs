using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BreslavskyaIV.Sprint2.Task4.V15.Lib
{
    public class DataService: ISprint2Task4V15 
    {
        public double Calculate(double x, double y)
        {
            double z = ((Math.Sqrt(x) / 2) > (Math.Sqrt(y) - 20)) ? Math.Pow(3 + 2 / (y * y), x) : Math.Cos(y) + 12 / (x * x);
            return Math.Round(z, 3);
        }
    }
}
