using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCSharpAssignment2
{
    class Employee
    {
        int EmpId;
        string name;
        double Salary, Hra, Ta, Da, PF, TDS, NetSalary, GrossSalary;
        

        public Employee(int EmpId, string name, double Salary)            //Consrtuctor
        {
            this.EmpId = EmpId;
            this.name = name;
            this.Salary = Salary;

        }
        public void HraCalculate()
        {
            if (Salary < 5000)
            {
                Hra = 0.1 * Salary;

            }
            else if (Salary < 10000)
            {
                Hra = 0.15 * Salary;

            }
            else if (Salary < 15000)
            {
                Hra = 0.2 * Salary;

            }
            else if (Salary < 20000)
            {
                Hra = 0.25 * Salary;

            }
            else
            {
                Hra = 0.3 * Salary;

            }
            Console.WriteLine(Hra);
        }
        public void TaCalculate()
        {
            if (Salary < 5000)
            {
                Ta = 0.05 * Salary;

            }
            else if (Salary < 10000)
            {
                Ta = 0.1 * Salary;

            }
            else if (Salary < 15000)
            {
                Ta = 0.15 * Salary;

            }
            else if (Salary < 20000)
            {
                Ta = 0.20 * Salary;

            }
            else
            {
                Ta = 0.25 * Salary;

            }
            Console.WriteLine(Ta);
        }
        public void DaCalculate()
        {
            if (Salary < 5000)
            {
                Da = 0.15 * Salary;

            }
            else if (Salary < 10000)
            {
                Da = 0.2 * Salary;

            }
            else if (Salary < 15000)
            {
                Da = 0.25 * Salary;

            }
            else if (Salary < 20000)
            {
                Da = 0.3 * Salary;

            }
            else
            {
                Da = 0.35 * Salary;

            }
            Console.WriteLine(Da);
        }

        public void DisplayDetails()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(name);
            Console.WriteLine(Salary);

            //Console.WriteLine(Ta);
            // Console.WriteLine(Da):
        }

        public void GrossSal()
        {
            GrossSalary = Salary + Hra + Da + Ta;
            Console.WriteLine(GrossSalary);
        }
        public void CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            Console.WriteLine(PF);
            TDS = 0.18 * GrossSalary;
            Console.WriteLine(TDS);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine(NetSalary);
        }
    }

    

    class LitwareLib
    {
        public static void Main(string[] args)
        {

            Employee emp = new Employee(1, "Kamaksha", 11000);
            emp.DisplayDetails();
            emp.HraCalculate();
            emp.TaCalculate();
            emp.DaCalculate();
            emp.GrossSal();
            emp.CalculateSalary();
        }
    }
}
