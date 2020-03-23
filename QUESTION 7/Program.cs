/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : For Loops
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTION_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //LEAP YEAR????

            bool leapFlag = false;

            Console.WriteLine("Enter a year and I'll tell you whether it's a leap year or not:");
            int year = int.Parse(Console.ReadLine());
            if (year < 1582)
            {
                if (year % 4 == 0)
                {
                    leapFlag = true; // Console.WriteLine("'Tis a leap year");
                }
                else
                {
                    //Console.WriteLine("'s not a leap year");

                }
            }
            else
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("'Tis a leap year");
                    }
                    else
                    {
                        Console.WriteLine("'s not a leap year");
                    }

                }
                else
                {
                    if (year % 4 == 0)
                    {
                        Console.WriteLine("'Tis a leap year");
                    }
                    else
                    {
                        Console.WriteLine("'s not a leap year");
                    }
                }
            }


        }
    }
}
