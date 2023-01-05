using System;
using System.Collections.Generic;
using System.Collections;

namespace OOPCSharpAssignment5._3
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<Employee> my_list = new List<Employee>();
          
           Console.WriteLine("Enter the number of Employees you want:");
            int size = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter the names of employee :");
           for (int i = 0; i <size;i++)
            {
                string name = Console.ReadLine();

                my_list.Add(new Employee(name));
            }

            Console.WriteLine("The list of employee is :");
            foreach (Employee emp in my_list)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("List Contains " + my_list.Count + " Employees");

        }
    }
}
