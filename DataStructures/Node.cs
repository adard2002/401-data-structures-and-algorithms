using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }

        public Node Next { get; set; }

        public int Value { get; set; }
    }
}
