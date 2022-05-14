using System;


namespace MyList
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyCustomList customList = new MyCustomList();
            customList.Add(1);
            Console.WriteLine(customList[0]);
            customList.Add(2);
            customList.Add(3);
            customList.Insert(1, 2);
            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }
            Console.WriteLine(customList.Contains(2));

            MyCustomStack myCustomStack = new MyCustomStack();
            myCustomStack.Push(1);
            myCustomStack.Push(2);
            Console.WriteLine(myCustomStack.Pop());
            myCustomStack.Push(4);
            myCustomStack.Push(5);
            myCustomStack.ForEach(x => Console.WriteLine(x*2));
        }
    }
}
