using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BreslavskyaIV.Sprint2.Task5.V12.Lib
{
    public class DataService: ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int gg = g - 1;
            int nn = n - 1;
            

            if (n == 1)
            {
                switch (m)
                {
                    case 1:
                        return "31.12." + gg;
                        
                    case 2:
                        return "31.01." + g;
                        
                    case 3:
                        return "29.02." + g;
                        
                    case 4:
                        return "31.03." + g;
                        
                    case 5:
                        return "30.04." + g;
                        
                    case 6:
                        return "31.05." + g;
                        
                    case 7:
                        return "30.06." + g;
                        
                    case 8:
                        return "31.07." + g;
                        
                    case 9:
                        return "31.08." + g;
                        
                    case 10:
                        return "30.09." + g;
                        
                    case 11:
                        return "31.10." + g;
                        
                    case 12:
                        return "30.11." + g;
                        
                    default:
                        throw new ArgumentException($"Месяц должен быть от одного до 12. Значение {m}");
                }
            }
            else
            {
                if (n<=10 && m<10)
                {
                    return "0" + nn + ".0" + m + "." + g;
                }
                else 
                {
                    if (n > 10 && m < 10)
                    {
                        return nn + ".0" + m + "." + g;
                    }
                    else
                    {
                        if (n > 10 && m >= 10)
                        {
                            return nn + "." + m + "." + g;
                        }
                        else
                        {
                            return "0";
                        }
                    }
                }
            }

        }
    
    }
}
