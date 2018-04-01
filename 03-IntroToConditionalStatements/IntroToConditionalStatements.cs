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
            int N = Convert.ToInt32(Console.ReadLine());

            string weird = "Weird";
            string notWeird = "Not Weird";
            string ans = "";

            if (N % 2 == 1)
            {
                ans = weird;
            }

            else if (N >= 2)
            {
                if (N > 20)
                {
                    ans = notWeird;
                }
                else if (N >= 6)
                {
                    ans = weird;
                }
                else if (N >= 2)
                {
                    ans = notWeird;
                }
            }

            Console.WriteLine(ans);

            Console.ReadKey();
        }
    }
}
