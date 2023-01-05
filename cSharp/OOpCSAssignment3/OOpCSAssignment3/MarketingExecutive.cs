using System;
using System.Collections.Generic;
using System.Text;

namespace OOpCSAssignment3
{
    class Marketing_Executive : Employee, Interface12
    {
        public Marketing_Executive(int EmpId, string name, double Salary):base(EmpId,name,Salary)
        {

        }
            double KilometerTravel;
            double TourAllowance;
            double TelephoneAllowance;
            double MkGrossSalary;
           
        public void MkExGrossSalary()
        {
            Console.WriteLine("Enter km");
            KilometerTravel = Convert.ToDouble(Console.ReadLine());
            TourAllowance = 5 * KilometerTravel;
            TelephoneAllowance = 1000;

            MkGrossSalary = Salary + Hra + Ta + Da + TourAllowance + TelephoneAllowance;
            Console.WriteLine(MkGrossSalary);

        }
        public override void CalculateSalary()
        {
          //base.CalculateSalary();
            PF = 0.1 * GrossSalary;
            Console.WriteLine("PF is:" + PF);
            TDS = 0.18 * GrossSalary;
            Console.WriteLine("TDS is:" + TDS);
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("Net Salary is:" + NetSalary);

        }
        public void DisplayDetail()
        {
            Console.WriteLine("Employee Id is: " + EmpId);
            Console.WriteLine("Employee name is: " + name);
            Console.WriteLine("Salary of Employee is: " + Salary);
           }
    }


}
