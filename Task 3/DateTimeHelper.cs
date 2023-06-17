using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3
{
    internal class DateTimeHelper
    {

        public static bool TryParseExact(string time, out DateTime result)
        {


            Regex regex = new Regex(@"^(0?[1 - 9] |[12][0 - 9] | 3[01])[\/\-](0?[1 - 9] | 1[012])[\/\-]\d{ 4 }$");

            //dd / mm / yyyy


            if (regex.IsMatch(time)) 
            {
                DateTime date1 = new DateTime(a, b, c)

            }

            return true;

        }
    }
}
