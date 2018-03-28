using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // Create phone book
                var phoneBook = new Dictionary<string, string>();

                // get number of entries
                int n = Convert.ToInt32(Console.ReadLine());

                // add entries to book
                for (int i = 0; i < n; i++)
                {
                    string[] inputs = Console.ReadLine().Split();

                    phoneBook[inputs[0]] = inputs[1];
                }

                // perform queries
                string queryKey;
                while ((queryKey = Console.ReadLine()) != null)
                {
                    if (phoneBook.ContainsKey(queryKey))
                    {
                        Console.WriteLine("{0}={1}", queryKey, phoneBook[queryKey]);
                    }
                    else {
                        Console.WriteLine("Not found");
                    }
                }
            }



        }
    }


