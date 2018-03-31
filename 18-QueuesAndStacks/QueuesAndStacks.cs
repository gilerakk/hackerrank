using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Solution
    {
        //Write your code here
        //LIFO
        Stack<char> stack = new Stack<char>();
        //FIFO
        Queue<char> queue = new Queue<char>();

        internal void pushCharacter(char character)
        {

            //vklada na zacatek - LIFO
            stack.Push(character);
        }

        internal void enqueueCharacter(char character)
        {

            //vklada na konec - FIFO
            queue.Enqueue(character);
        }

        internal char popCharacter()
        {
            //smaze a vraci od zacatku - LIFO
            char result = stack.Pop();
            return result;
        }

        internal char dequeueCharacter()
        {
            //smaze a vraci od zacatku - FIFO
            char result = queue.Dequeue();
            return result;
        }




        static void Main(string[] args)
        {
            // read the string s.
            Console.WriteLine("Zadej string na overeni palindromu");
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }

            Console.ReadKey();
        }
    }
    
}
