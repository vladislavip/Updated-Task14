using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class ArrayHelpers
    {

        public static string Trim(string str)


        {
            int forwardTail = 0;
            int backwardTail = 0;

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ')

                {
                    forwardTail = i;
                    break;
                }

            }

            for (int j = str.Length - 1; j >= 0; j--)
            {

                if (str[j] != ' ')

                {
                    backwardTail = j;
                    break;
                }

            }



            string newstring = str.Substring(forwardTail, backwardTail - forwardTail + 1);

            return newstring;



        }

        public static string TrimSart(string str)
        {


            int forwardTail = 0;


            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ')

                {
                    forwardTail = i;
                    break;
                }

            }

            string newstring = str.Substring(forwardTail);
            return newstring;

        }

        public static string TrimEnd(string str)

        {

            int backwardTail = 0;



            for (int j = str.Length - 1; j >= 0; j--)
            {

                if (str[j] != ' ')

                {
                    backwardTail = j;
                    break;
                }
            }
            string newstring = str.Substring( 0, backwardTail+1 );

            return newstring;
        }
    }
}
