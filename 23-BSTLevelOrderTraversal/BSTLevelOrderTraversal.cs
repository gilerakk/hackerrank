using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Solution
    {
        static void levelOrder(Node root)
        {
            //Write your code here
            Queue<Node> fronta = new Queue<Node>();
            if (root != null)
            {
                //prida node na konec fronty
                fronta.Enqueue(root);

                while (fronta.Count != 0)
                {
                    //ulozi Node do tmpNode a odstrani ho ve fronte - fronta je prazdna
                    Node tmpNode = fronta.Dequeue();
                    Console.Write(tmpNode.data + " ");

                    //je dite vlevo
                    if (tmpNode.left != null)
                    {
                        //pridame do fronty dite vlevo - jsme o uroven nize
                        fronta.Enqueue(tmpNode.left);
                    }

                    //je dite vpravo
                    if (tmpNode.right != null)
                    {
                        //pridame do fronty dite vpravo - jsme o uroven nize
                        fronta.Enqueue(tmpNode.right);
                    }
                }
                               
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
            
        }
    }
}
