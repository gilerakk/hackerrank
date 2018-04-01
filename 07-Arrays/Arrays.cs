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
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int[] ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                ans[n - 1 - i] = arr[i];
            }

            for (int j = 0; j < n; ++j)
            {
                Console.Write(ans[j] + " ");
            }

            Console.ReadKey();
        }
    }
}
