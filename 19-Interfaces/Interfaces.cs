using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    class Calculator : AdvancedArithmetic
    {
        public Calculator()
        {

        }

        //metoda, ktera implementuje interface musi byt public
        public int divisorSum(int n)
        {
            //HackerRank nema using System.Collections.Generic, takze nejde pouzit LinkedList
            //LinkedList<int> linkedList = new LinkedList<int>();
            int sum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    //linkedList.AddLast(i);
                    sum += i;
                }
                
            }

            //return linkedList.Sum();
            return sum;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej cislo - spocita sumu vsech sudych delitelu");
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            Console.ReadKey();
        }
    }
}
