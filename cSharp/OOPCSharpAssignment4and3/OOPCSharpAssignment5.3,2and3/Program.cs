using System;

namespace OOPCSharpAssignment5._3_2and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            MyStack m = new MyStack();
            try
            {
                do
                {
                    Console.WriteLine("\nEnter your choice: ");
                    Console.WriteLine("1. Push");
                    Console.WriteLine("2. Pop");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. Clone");
                    Console.WriteLine("5. Exit");

                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter elements of Array: ");
                          /*  for (int i = 0; i <= size; i++)
                            {*/
                                int num = Convert.ToInt32(Console.ReadLine());

                                m.push(num);
                            
                            break;
                        case 2:
                            m.pop();
                            break;
                        case 3:
                            m.display();
                            break;
                        case 4:
                            MyStack newStack = m.clone() as MyStack;
                            newStack.display();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("You Have Entered Invalid choice: ");
                            break;

                    }
                }
                while (n != 5);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
