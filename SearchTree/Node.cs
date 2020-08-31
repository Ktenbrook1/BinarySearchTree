using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTree
{
    class Node
    {
        public int Data;
        public Node RightNode;
        public Node LeftNode;

        public Node(int data)
        {
            Data = data;
        }
    }
}
