using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    public class DoubleLinkedList
    {
        private bool reversed = false;
        private int count = 0;
         public Node Head { get; set; }
        public Node Tail { get; set; }

        public void Reverse()
        {
            var temp = Tail;
            Tail = Head;
            Head = temp;
            reversed = !reversed;
        }
        public void AddHead(Node node)
        {
            count++;
            if (Head==null)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Next=Head;
            Head.Previous = node;
            Head = node;
        }

        public void AddTail(Node node)
        {
            count++;
            if (Head==null)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Previous = Tail;
            Tail.Next = node;
            Tail = node;
        }

        public void Foreach(Action<Node> action)
        {
            Node current = Head;
            while (current != null)
            {
                action(current);
                if (reversed)
                {
                    current = current.Previous;
                }
                else
                {
                    current = current.Next;
                }
            }
        }
    }
}
