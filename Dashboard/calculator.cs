using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class calculator
    {
        int value1;
        int value2;
        int calculated;
        string wayToCalculate;

        public int calculate(int value1, int value2, string wayToCalculate)
        {
            if (wayToCalculate == "+")
            {
               return value1 + value2;
            }else if (wayToCalculate == "-")
            {
                return value1 - value2;
            }else if (wayToCalculate == "/")
            {
                return value1 / value2;
            }else if(wayToCalculate == "*")
            {
                return value1 * value2;
            }
            return 0;
        }
    }
}
