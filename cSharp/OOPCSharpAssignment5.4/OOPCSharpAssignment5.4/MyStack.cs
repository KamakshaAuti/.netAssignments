using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCSharpAssignment5._4
{
    class MyStack<T>
    {
        private T[] Arr = new T[10];
        private int top = -1;
        private int size;

      
        public int SIZE { get { return size; } set { this.size = Array.Length; } }

        public MyStack()
        {
            this.SIZE = SIZE;
        }
        public void push(T element)
        {
            try
            {
                if (top == SIZE - 1)
                {
                    throw new Exception("Fullstack Exception");
                }
                Arr[++top] = element;
                Console.WriteLine("\nPushed " + element + " onto the Stack");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new Exception("EmptyStack Exception");
                }
                Console.WriteLine("\n" + Arr[top] + "Popped");
                Array.Clear(Arr, top--, 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public void display()
        {
            Console.WriteLine("Printing Array: ");
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(Arr[i] + " ");
            }
        }
    }
}
