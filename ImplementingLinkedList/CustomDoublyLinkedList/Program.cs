using System;

namespace CustomDoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            //for (int i = 0; i < 5; i++)
            //{
            //    doublyLinkedList.AddFirst(new Node(i));
            //}
            //var currentNode = doublyLinkedList.Tail;
            //while (currentNode!=null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Previous;
            //}

            //if (doublyLinkedList.Head!=null)
            //{
            //    Console.WriteLine(doublyLinkedList.RemoveFirst().Value);
            //}
            //doublyLinkedList.RemoveFirst();
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            for (int i = 0; i < 3; i++)
            {
                doublyLinkedList.AddHead(new Node(i));
            }

            for (int i = 0; i < 3; i++)
            {
                doublyLinkedList.AddLast(new Node(i));
            }
            //Console.WriteLine("Remove: "+ doublyLinkedList.RemoveTail().Value);
            //var current = doublyLinkedList.Tail;
            //while (current!=null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Previous;
            //}

            Console.WriteLine("Foreach from head:");
            doublyLinkedList.ForeachFromHead(node =>
            {
                Console.WriteLine($"from action: {node.Value}");
            });

            doublyLinkedList.ForeachFromTail(node =>
            {
                Console.WriteLine("sfsssg " + node.Value);
            });

            int[] linkedAsArray = doublyLinkedList.ToArray();
            Console.WriteLine(String.Join(" ",linkedAsArray));
            Console.WriteLine("Remove head: " + doublyLinkedList.RemoveHead().Value);
            Console.WriteLine("Remove tail: " + doublyLinkedList.RemoveTail().Value);
        }
    }
}
