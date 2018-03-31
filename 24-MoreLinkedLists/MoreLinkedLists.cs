using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    class Solution
    {
        public static Node removeDuplicates(Node head)
        {
            //Write your code here
            if (head == null || head.next == null)
            {
                return head;                        
            }

            else
            {
                //pokud jsou dve po sobe jdouci cisla stejna
                if (head.data == head.next.data)
                {
                    //preskoc prvni duplikovany node
                    head.next = head.next.next;
                    //pokracuj v kontrole
                    removeDuplicates(head);
                }
                //pokud nejsou dve po sobe jdouci cisla stejna
                else
                {
                    //jdi na dalsi node
                    removeDuplicates(head.next);
                }

                return head;
            }
            

        }


        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(string[] args)
        {
            Node head = null;
            Console.WriteLine("Zadej pocet prvku:");
            int T = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej neklesajici cisla - kazde na novy radek:");
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            Console.WriteLine("Prvky po odstraneni duplikatu:");
            display(head);
            Console.ReadKey();

        }
    }
}
