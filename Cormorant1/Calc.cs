using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cormorant1
{
    public class Calc
    {
        public static double Divide(double b, double y)
        {
            double answer = b / y;
            return answer;
        }

        public static double Multiple(double b, double y)
        {
            double answer = b * y;
            return answer;
        }

        public static double Add(double b, double y)
        {
            double answer = b + y;
            return answer;
        }

        public static double Power(double b, double y)
        {
            double answer = Math.Pow(b, y);
            return answer;
        }
    }
}
    