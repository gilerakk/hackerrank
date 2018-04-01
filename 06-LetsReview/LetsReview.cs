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
            int itr = 0;
            int testCases = Int16.Parse(Console.ReadLine());
            string[] myString = new string[testCases];

            while (itr < testCases)
            {
                myString[itr] = Console.ReadLine();
                itr++;
            }

            foreach (var str in myString)
            {
                char[] myStringArray = str.ToCharArray();
                string outputEven = "";
                string outputOdd = "";

                for (int i = 0; i < myStringArray.Length; i++)
                {
                    if (i % 2 == 0 || i == 0)
                    {
                        outputEven += myStringArray[i];
                    }
                    else
                    {
                        outputOdd += myStringArray[i];
                    }
                }

                Console.WriteLine($"{outputEven} {outputOdd}");

            }

            Console.ReadKey();
        }
    }
}
