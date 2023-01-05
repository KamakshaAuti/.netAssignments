using System;

namespace OOpCSAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Manager mg = new Manager(2, "Dnyana", 40000);
            mg.DisplayDetails();
            mg.MngGrossSal();
         mg.CalculateSalary();   

            /*Marketing_Executive mk = new Marketing_Executive(3, "Sujita", 50000);
            mk.DisplayDetails();
            mk.CalculateSalary();
            */
        }
    }
}
