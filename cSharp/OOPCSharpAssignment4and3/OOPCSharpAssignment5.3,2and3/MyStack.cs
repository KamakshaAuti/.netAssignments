using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCSharpAssignment5._3_2and3
{
   
    public class MyStack : ICloneable
    {
        public int[] Array = new int[20];
        public int top = -1;
        public int size;

        public object clone()
        {
            Console.WriteLine("Cloned Array is: ");
            MyStack newStack = new MyStack
            {
                Array = this.Array,
                top = this.top,
                size = this.size
            };
            return newStack;
        }
        public int SIZE { get { return size; } set { this.size = Array.Length; } }
        
        public void push(int a)
        {
            if(top == Array.Length-1)
            {
                throw new Exception("Fullstack Exception");
            }
            Array[++top] = a;
            Console.WriteLine("\nPushed " +a+ " onto the Stack");
        }
        public void pop()
        {
            if (top == - 1)
            {
                throw new Exception("Fullstack Exception");
            }
            Console.WriteLine( "\n" +Array[top] + "Popped");
            Array[top--] = 0;
        }
        public void display()
        {
            Console.WriteLine("Printing Array: ");
            foreach(int i in Array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
