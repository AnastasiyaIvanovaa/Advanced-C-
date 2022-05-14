using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    public class MyCustomStack
    {
        private const int InitialCapacity = 4;
        private int[] array;
        private int count;

        public MyCustomStack()
        {
            this.count = 0;
            this.array = new int[InitialCapacity];
        }

        public int Count { get { return this.count; } }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.array[i]);
            }
        }
        public int Peek()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return this.array[this.count-1];
        }
        public int Pop()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            int element = this.array[this.count - 1];
            this.array[this.count - 1] = default;
            this.count--;
            return element;
        }
        public void Push(int element)
        {
            if (this.array.Length==this.count)
            {
                this.Resize();
            }
            this.array[this.count] = element;
            this.count++;
        }

        public int[] Resize()
        {
            int[] copy = new int[this.array.Length*2];
            Array.Copy(this.array, copy, this.Count);
            return this.array=copy;
        }
    }
}
