using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num3, double num4)
        {
            return num3 + num4;
        }

        public static string Add(int num5, int num6, bool maybe)
        {
            int sum = num5 + num6;
            if (maybe)
            {
                if (sum > 1 && sum < 2)
                {
                    return $"{sum} dollar.";
                }
                else if (sum > 2)
                {
                    return $"{sum} dollars.";
                }
            }
            return $"{sum}";
        }
    }
}
