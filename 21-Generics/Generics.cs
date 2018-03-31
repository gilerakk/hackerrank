using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Printer
    {
        /**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
        // Write your code here
        //vstupni parametr pole generickych prvku
        public static void PrintArray<T>(T[] inputs)
        {
            foreach (var input in inputs)
            {
                Console.WriteLine(input.ToString());
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Zadej pocet pozadovanych prvku - integer:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadej hodnoty prvku po radcich.");
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Zadej pocet pozadovanych prvku - string:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadej hodnoty prvku po radcich.");
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Vypis prvku - integer:");
            PrintArray<Int32>(intArray);
            Console.WriteLine("Vypis prvku - string:");
            PrintArray<String>(stringArray);

            Console.ReadKey();
                        
        }
    }
}
