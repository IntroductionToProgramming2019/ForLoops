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

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 40; i < 61; i++)
            {
                if ((i == 46)||(i == 48))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
