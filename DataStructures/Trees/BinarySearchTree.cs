using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinarySearchTree
    {
            public Node Root { get; set; }
        


        // root >> left >> right
        // ====== PreOrder ======
        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrder(Root, result);
            return result;
        }

        private void PreOrder(Node node, List<int> result)
        {
            result.Add(node.Value);

            if (node.Left != null)
                PreOrder(node.Left, result);

            if (node.Right != null)
                PreOrder(node.Right, result);
        }


        // left >> root >> right
        // ====== inOrder ======
        public List<int> inOrder()
        {
            List<int> result = new List<int>();
            inOrder(Root, result);
            return result;
        }

        private void inOrder(Node node, List<int> result)
        {
            if (node.Left != null)
                inOrder(node.Left, result);

            result.Add(node.Value);

            if (node.Right != null)
                inOrder(node.Right, result);
        }


        // left >> right >> root
        // ====== postOrder ======
        public List<int> postOrder()
        {
            List<int> result = new List<int>();
            postOrder(Root, result);
            return result;
        }

        private void postOrder(Node node, List<int> result)
        {
            if (node.Left != null)
                postOrder(node.Left, result);

            if (node.Right != null)
                postOrder(node.Right, result);

            result.Add(node.Value);

        }

        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
    }
}
