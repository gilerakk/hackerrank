using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    abstract class Book
    {

        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }
        //nazev metody by mel zacinat velkym pismenem, ale na hackerranku maji s malym
        public abstract void display();


    }

    class MyBook : Book
    {

        private int _price;

        internal MyBook(string tit, string auth, int price) : base(tit, auth)
        {
            title = tit;
            author = auth;
            _price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + _price);
        }
    }


    class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titul knihy:");
            string title = Console.ReadLine();

            Console.WriteLine("Autor knihy:");
            string author = Console.ReadLine();

            Console.WriteLine("Cena knihy:");
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
            Console.ReadKey();
        }
    }
}
