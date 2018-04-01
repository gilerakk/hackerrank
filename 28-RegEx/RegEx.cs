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
            List<string> list = new List<string>();

            //Console.WriteLine("Zadej pocet prvku: ");
            int N = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Zadej krestni jmeno a email oddeleny mezerou.");
            for (int a0 = 0; a0 < N; a0++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];

                var regex = new System.Text.RegularExpressions.Regex("(@gmail.com)$");
                if (regex.Match(emailID).Success)
                {
                    list.Add(firstName);
                }
                

            }

            list.Sort();

            //Console.WriteLine("Setrizeny seznam podle jmena, ktere obsahuji email @gmail.com");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
                      
            Console.ReadKey();
        }
    }
}
