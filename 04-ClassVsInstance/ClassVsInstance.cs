using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (initialAge < 0)
            { 
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }
            else
            { 
                age = initialAge;
            }
        }
        public void amIOld()
        {
            Console.WriteLine(
                (age >= 18)
                ? "You are old."
                : (
                    (age >= 13)
                    ? "You are a teenager."
                    : "You are young."
                )
            );
        }

        public void yearPasses()
        {
            age++;
        }

        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
