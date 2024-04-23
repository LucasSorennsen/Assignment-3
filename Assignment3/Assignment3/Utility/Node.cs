using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class Node
    {
        public int data;

        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
