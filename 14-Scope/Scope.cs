using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        // Add your code here
        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            int max = 0;
            int min = 0;

            max = elements.Max();
            min = elements.Min();


            /*
            //hledani v poli za pomoci LINQ
            var vysledek = from element in elements
                        where element > 100
                        select element;
            */

            maximumDifference = max - min;          

        }



    } // End of Difference Class

    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.ReadKey();
        }
    }
}
