using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    public class Node
    {
        private int value;

        public Node(int value)
        {
            Value=value;
        }

        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}
