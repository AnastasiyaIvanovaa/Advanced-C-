using System;

namespace ReverseLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(); 
            for (int i = 0; i < 3; i++)
            {
                doubleLinkedList.AddHead(new Node(i));
            }

            Node current = doubleLinkedList.Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next; 
            }
            for (int i = 3; i < 6; i++)
            {
                doubleLinkedList.AddTail(new Node(i));
            }
            Node current1=doubleLinkedList.Tail;    
            while (current1!=null)
            {
                Console.WriteLine(current1.Value);
                current1=current1.Previous;
            }
            doubleLinkedList.Reverse();
            doubleLinkedList.Foreach((node) =>
            {
                Console.WriteLine(node.Value);
            });
        }
    }
}
