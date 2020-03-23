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

namespace QUESTION_1_ii_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 40;
            while ((i > 39)&&(i < 61))
            {
                Console.WriteLine(i);
                i = i + 1;
            }

        }
    }
}
