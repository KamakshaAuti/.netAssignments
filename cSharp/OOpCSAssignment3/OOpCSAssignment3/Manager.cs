using System;
using System.Collections.Generic;
using System.Text;

namespace OOpCSAssignment3
{
    class Manager : Employee,Interface12
    {
        
        double PetrolAllowance;
        double FoodAllowance;
        double OtherAllowance;
        double MngGrossSalary;

        public override void CalculateSalary()
        {
   //    Double gs = MngGrossSalary - (PetrolAllowance + FoodAllowance + OtherAllowance);
            PF = 0.1 * GrossSalary;
            Console.WriteLine("PF is:" + PF);
            TDS = 0.18 * GrossSalary;
            Console.WriteLine("TDS is:" + TDS);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("Net Salary is:" + NetSalary);
        }
        public void MngGrossSal()
        {
            PetrolAllowance = 0.08 * Salary;
            FoodAllowance = 0.13 * Salary;
            OtherAllowance = 0.03 * Salary;
            MngGrossSalary = GrossSalary + Hra + Ta + PetrolAllowance + FoodAllowance + OtherAllowance;
            Console.WriteLine("Gross Salary of Employee is: " +MngGrossSalary);
        }
        
        public Manager(int EmpId, string name, double Salary) : base(EmpId, name, Salary)
        {

        }
        public void DisplayDetail()
        {
            Console.WriteLine("Employee Id is: "+EmpId);
            Console.WriteLine("Employee name is: "+name);
            Console.WriteLine("Salary of Employee is: "+Salary);
            
        }
    }
}
