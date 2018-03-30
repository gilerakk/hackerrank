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
            Console.WriteLine("Zadej string, ktery chces prevest na cislo:");
            string S = Console.ReadLine();
            int result = 0;

            try
            {
                result = int.Parse(S);
                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
                Console.ReadKey();
            }

            /*
            if (int.TryParse(S, out result))
            {
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Bad String");
                Console.ReadKey();
            }
            */
        }
    }
}
