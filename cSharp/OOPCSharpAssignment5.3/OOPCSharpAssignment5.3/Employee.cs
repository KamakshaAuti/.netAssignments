using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCSharpAssignment5._3
{
    public class Employee
    {
        public string name;

        public Employee(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return(name);
        }
    }

}
