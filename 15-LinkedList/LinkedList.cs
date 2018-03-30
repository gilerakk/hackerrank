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
        public static Node insert(Node head, int data)
        {
            //Complete this method
            // if list has no elements, return a new node
            if (head == null)
            {
                return new Node(data);
            }
            // else iterate through list, add node to tail, and return head
            Node tmp = head;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = new Node(data);

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
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);

            Console.ReadKey();

            /*
            //LinkedList
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> node = new LinkedListNode<int>(1);
            list.AddAfter(node, 5);
            list.AddBefore(node, 6);
            list.AddFirst(1);
            list.AddLast(100);
            */
            

        }
    }
}
