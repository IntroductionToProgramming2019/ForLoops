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

namespace QUESTION_5
{
    class Program
    {
        static int[] values = new int[5];
        static void Main(string[] args)
        {
            for (int i = 0; i < values.Length ; i++)
            {
                Console.WriteLine("Enter a value: ");
                values[i] = int.Parse(Console.ReadLine());
            }
            int average = Average();
            int highest = HighestNum();
            int lowest = LowestNum();
            Console.WriteLine("The average is {0}, the highest is {1}, the lowest is {2}", average, highest, lowest);
        }
        static int Average()
        {
            int av = 0;
            for (int i = 0; i < values.Length - 1; i++)
            {
                av = av + values[i];
            }
            av = (av) / (values.Length);
            return av;
        }
        static int HighestNum()
        {
            int highest = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > highest)
                {
                    highest = values[i];
                }
                else
                {

                }
            }
            return highest;
        }
        static int LowestNum()
        {
            int lowest = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < lowest)
                {
                    lowest = values[i];
                }
                else
                {

                }
            }
            return lowest;
        }
    }
}