using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] arrActual = Console.ReadLine().Split(' ');
            DateTime actualDate = new DateTime(Convert.ToInt16(arrActual[2]), Convert.ToInt16(arrActual[1]), Convert.ToInt16(arrActual[0]));

            string[] arrExpected = Console.ReadLine().Split(' ');
            DateTime expectedDate = new DateTime(Convert.ToInt16(arrExpected[2]), Convert.ToInt16(arrExpected[1]), Convert.ToInt16(arrExpected[0]));

            //Moznost A
            /*
            if (actualDate.Year > expectedDate.Year)
            {
                Console.WriteLine("10000");
            }
            else if ((actualDate.Month > expectedDate.Month) && (actualDate.Ticks >= expectedDate.Ticks))
            {
                int result = 500 * (actualDate.Month - expectedDate.Month);
                Console.WriteLine(result);
            }
            else if (actualDate.Day > expectedDate.Day && (actualDate.Ticks >= expectedDate.Ticks))
            {
                int result = 15 * (actualDate.Day - expectedDate.Day);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("0");
            }
            */

            //Moznost B
            if (actualDate.Year == expectedDate.Year)
            {
                if (actualDate.Month > expectedDate.Month)
                {
                    int result = 500 * (actualDate.Month - expectedDate.Month);
                    Console.WriteLine(result);
                }
                else if (actualDate.Month == expectedDate.Month && actualDate.Day > expectedDate.Day)
                {
                    int result = 15 * (actualDate.Day - expectedDate.Day);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else if (actualDate.Year > expectedDate.Year)
            {
                Console.WriteLine("10000");
            }
            else
            {
                Console.WriteLine("0");
            }
                        
            Console.ReadKey();
            
        }
    }
}
