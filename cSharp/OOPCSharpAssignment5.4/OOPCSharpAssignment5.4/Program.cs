using System;

namespace OOPCSharpAssignment5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.push("Kamakshsa");
            stack.push("Dnyaneshwari");
            stack.push("Suji");
            stack.push("Bithi");
            stack.push("Vishakha");
            stack.push("Anita");
            stack.pop();
            stack.display();
            Console.WriteLine();
        }
    }
}
