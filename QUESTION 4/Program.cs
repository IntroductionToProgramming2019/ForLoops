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

namespace QUESTION_4
{
    class Program
    {
        static int[] values = new int[6];
        static void Main(string[] args)
        {
            int odds = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter a value: ");
                values[i] = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    odds = odds + 1;
                }
            }
            Console.WriteLine(odds);
        }
    }
}
