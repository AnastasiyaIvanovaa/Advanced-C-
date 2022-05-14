using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    public class MyCustomList
    {
        private const int InitialCapacity = 2;
        private int[] array;

        public MyCustomList()
        {
             this.array = new int[InitialCapacity];
        }
        public int this[int index]
        {
            get
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid Index!");
                }
                return array[index];
            }
            set
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid Index!");
                }
                this.array[index] = value;
            }
        }
        public int Count { get; private set; }
        public int indexer { get; private set; }

        public void Add(int element)
        {
            if (array.Length==this.Count)
            {
                this.Resize();
            }
            this.array[this.Count] = element;
            this.Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i]==element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex>=this.Count || secondIndex>=this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            int firstElement = this.array[firstIndex];
            this.array[firstIndex] = this.array[secondIndex];   
            this.array[secondIndex]=firstElement;
        }
        public void Insert(int index,int element)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }
            if (index==this.Count)
            {
                this.Add(element);
            }
            else
            {
            ShiftRight(index, element);
            }
            this.Count++;
        }

        private void ShiftRight(int index, int element)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
            this.array[index] = element;
        }

        public int RemoveAt(int index)
        {
            if (index>=this.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index!!!");
            }
            int element = this.array[index];
            this.array[index] = default;
            this.Shift(index);
            this.Count--;
            if (this.Count<=this.array.Length/4)
            {
                this.Shrink();
            }
            return element;
        }
        private int[] Resize()
        {
               int[] copy = new int[array.Length * 2];
            Array.Copy(this.array,copy,this.Count);
            this.array = copy;
            return this.array; 
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.array.Length-1; i++)
            {
                this.array[index] = this.array[index + 1];
            }

        }

        private void Shrink()
        {
            int[] copy = new int[this.array.Length/2];
            Array.Copy(this.array, copy, this.Count);
             this.array=copy;
        }

        
    }
}
