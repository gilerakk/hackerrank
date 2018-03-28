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
            int remainder = 0;
            List<int> list = new List<int>();
            string result = "";
            int consecutive = 0;
            int maxValue = 0;
            
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                remainder = n % 2;

                if (remainder == 1)
                {
                    consecutive++;
                    maxValue = Math.Max(maxValue, consecutive);
                                        
                }
                else
                {
                    consecutive = 0;
                }
                

                n = n / 2;
                list.Add(remainder);


            }

            for (int i = 0; i < list.Count; i++)
            {
                result += list[list.Count - i - 1];
            }

            Console.WriteLine("Vypocet: " + result);
            Console.WriteLine("Consecutive: " + maxValue);
            Console.ReadLine();

        }
    }
}
