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
            //Console.WriteLine("Zadej pocet prvku: ");
            int n = Convert.ToInt16(Console.ReadLine());
                        
            int[] arr = new int[n];
            //Console.WriteLine("Zadej cisla - na kazdy radek jedno: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] =  Convert.ToInt32(Console.ReadLine());
            }
                        
            foreach (int item in arr)
            {
                bool prime = true;
                int counter = 2; //deleni jednickou se nepocita, takze zacinam dvojkou
                //jednicka je not prime
                if (item == 1)
                {
                    prime = false;
                }
                while (counter*counter <= item)
                {
                    if (item % counter == 0)
                    {
                        prime = false;
                        break;
                    }
                    counter++;
                }

                //Console.WriteLine("Pocet iteraci: " + counter);

                if (prime == false)
                {
                    Console.WriteLine("Not prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
            

            for (int i = 2; i*i <= n; i++)
            {

            }

            Console.ReadKey();
            
        }
    }
}
