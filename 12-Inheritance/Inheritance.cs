using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student()
        {
        
        }

        public Student(string firstName, string lastName, int identification, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        internal char Calculate()
        {
            char result = 'x';
            int sumScores = 0;
            float avgScore = 0;

            foreach (int score in testScores)
            {
                sumScores += score;
            }

            avgScore = sumScores / testScores.Length;


            if (avgScore >= 90 && avgScore <= 100)
            {
                result = 'O';
            }
            else if (avgScore >= 80 && avgScore < 90)
            {
                result = 'E';
            }
            else if (avgScore >= 70 && avgScore < 80)
            {
                result = 'A';
            }
            else if (avgScore >= 55 && avgScore < 70)
            {
                result = 'P';
            }
            else if (avgScore >= 40 && avgScore < 55)
            {
                result = 'D';
            }
            else if (avgScore < 40)
            {
                result = 'T';
            }

            return result;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej: Jmeno Prijmeni ID");
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);

            Console.WriteLine("Zadej pocet vysledku");
            int numScores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadej vysledky oddelene mezerou");
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadKey();
        }
    }
}
