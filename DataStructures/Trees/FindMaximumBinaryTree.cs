using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class FindMaximumBinaryTree
    {
        // Creating binary tree node(s)
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }
        public class BinaryTree
        {
            public Node root;

            // Returning max value
            public static int findMax(Node node)
            {
                if (node == null)
                {
                    return int.MinValue;
                }
                int res = node.data;
                int lres = findMax(node.left);
                int rres = findMax(node.right);

                if (lres > res)
                {
                    res = lres;
                }

                if (rres > res)
                {
                    res = rres;
                }
                return res;
            }

            // list of values in the tree
            public static void Main(string[] args)
            {
                BinaryTree tree = new BinaryTree();
                tree.root = new Node(2);
                tree.root.left = new Node(5);
                tree.root.right = new Node(10);
                tree.root.left.left = new Node(7);
                tree.root.left.right = new Node(24);
                tree.root.right.right = new Node(3);

                Console.WriteLine("The max value in the binary tree is " + BinaryTree.findMax(tree.root));
            }
        }
    }
}
