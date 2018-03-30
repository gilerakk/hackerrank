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
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        internal void pushCharacter(char character)
        {
            
            stack.Push(character);
        }

        internal void enqueueCharacter(char character)
        {
            
            queue.Enqueue(character);
        }

        internal char popCharacter()
        {
            char result = stack.Pop();
            return result;
        }

        internal char dequeueCharacter()
        {
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
