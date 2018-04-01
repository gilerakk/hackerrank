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
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            int totalCost = Convert.ToInt16(meal_cost + (meal_cost * tip_percent / 100) + (meal_cost * tax_percent / 100));
            Console.WriteLine("The total meal cost is {0} dollars.", totalCost);

            Console.ReadKey();
        }
    }
}
