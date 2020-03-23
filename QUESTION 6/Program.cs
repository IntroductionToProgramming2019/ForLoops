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

namespace QUESTION_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double hours = 0;
            double total = 0;
            Console.WriteLine("Enter the number of hours(-999 to quit): ");
            hours = int.Parse(Console.ReadLine());
            while (hours != -999)
            {
                double cost = FindCost(hours);
                total = cost + total;
                Console.WriteLine("The cost of this session is {0:c}", cost);
                Console.WriteLine("The total cost is {0:c}", total);
                Console.WriteLine();
                Console.WriteLine("Enter the number of hours(-999 to quit): ");
                hours = int.Parse(Console.ReadLine());

            }

        }
        static double FindCost(double hours)
        {
            double cost = 2;
            cost = cost + (hours * 0.50);
            if (cost >= 10)
            {
                cost = 10;
            }
            return cost;

        }
    }
}
