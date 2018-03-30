using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Calculator
    {
        private int _n;
        private int _p;
        private int result;

        public Calculator()
        {

        }

        internal int power(int n, int p)
        {
            _n = n;
            _p = p;

            if (_n < 0 || _p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            else
            {
                result = Convert.ToInt32(Math.Pow(_n, _p));
                return result;
            }
                     
                       
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();

            Console.WriteLine("Zadej pocet vypoctu:");
            int T = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Zadej zaklad mocniny a exponent oddeleny mezerou:");
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                                
            }

            Console.ReadKey();

        }
    }
}
