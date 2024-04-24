using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class Node
    {
        public User data;

        public Node next;

        public Node(User d)
        {
            data = d;
            next = null;
        }
    }
}
