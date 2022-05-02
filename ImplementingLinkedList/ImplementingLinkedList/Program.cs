using System;

namespace ImplementingLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Node head = new Node(1);
            //Node head2 = new Node(2);
            //Node head3= new Node(3);
            //Node head4 = new Node(4);

            //head.Next = head2;
            //head2.Next= head3;
            //head3.Next= head4;

            //Node currentNode = head;

            //while (currentNode!=null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
            //}

            SoftUniLinkedList linkedList = new SoftUniLinkedList();
           
            for (int i = 0; i < 20; i++)
            {
                linkedList.AddHead(new Node(i));
            }

            var currentNode = linkedList.Head;
            while (currentNode!=null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            var current = linkedList.Tail;
            while (current!=null)
            {
                Console.WriteLine(current.Value);
                current=current.Previous;
            }


        }
    }
}
