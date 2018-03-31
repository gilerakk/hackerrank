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
        static int getHeight(Node root)
        {
            //Write your code here
            int leftNode = 0;
            int rightNode = 0;

            if (root == null)
            {
                return -1;
            }
            
            leftNode = 1 + getHeight(root.left);
            rightNode = 1 + getHeight(root.right);

            return Math.Max(leftNode, rightNode);
            
            
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
            Console.WriteLine("Zadej pocet prvku:");
            int T = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zadej cisla na jednotlive radky:");
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine("Nejdelsi vyska binarniho stromu:");
            Console.WriteLine(height);
            Console.ReadKey();
        }
    }
}
