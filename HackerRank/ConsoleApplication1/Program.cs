using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Solution
    {

        static int factorial(int n)
        {
            if (n >= 2 && n <= 12)
            {
                int result = n;

                while (n > 1)
                {
                    result = result * (n - 1);
                    n--; 
                }

                return result;
            }
            else
            {
                return 0;
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = factorial(n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
