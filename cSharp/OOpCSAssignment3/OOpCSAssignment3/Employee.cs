using System;
using System.Collections.Generic;
using System.Text;

namespace OOpCSAssignment3
{
    public class Employee 
    {      
            public int EmpId;
            public string name;
            public double Salary, Hra, Ta, Da, PF, TDS, NetSalary, GrossSalary;
            /*public int EMPID { set; get; }
             public string NAME { set; get; }
             public double SALARY  { set; get; }*/

            public Employee(int EmpId, string name, double Salary)            //Consrtuctor
            {
            if (EmpId <= 0)
            {
                throw new Exception("EmpNo empty is ot allowed");

            }
            else
            {
                this.EmpId = EmpId;
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("EmpName empty is ot allowed");

            }
            else
            {
                this.name = name;
            }

            if (Salary <= 0)
            {
                throw new Exception("Salary empty is ot allowed");

            }
            else
            {
                this.Salary = Salary;
            }

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
                Console.WriteLine("Hra is: " +Hra);
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
                Console.WriteLine("Ta is:"+Ta);
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
            Console.WriteLine("da is:" + Da);
        }



        public void GrossSal()
            {
                GrossSalary = Salary + Hra + Da + Ta;
            Console.WriteLine(GrossSalary);

        }
        public virtual void CalculateSalary()
            {
                PF = 0.1 * GrossSalary;
                Console.WriteLine("PF is :",+PF);
                TDS = 0.18 * GrossSalary;
            Console.WriteLine("TDS is:" + TDS);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("Net Salary is:" + NetSalary);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Id is: " + EmpId);
            Console.WriteLine("Employee name is: " + name);
            Console.WriteLine("Salary of Employee is: " + Salary);
           //onsole.WriteLine("Gross Salary of Employee is: " + GrossSalary);

        }


    }
}

