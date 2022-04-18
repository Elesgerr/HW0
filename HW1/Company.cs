using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Models
{
    class Company
    {

        
       public string Name;   
       public int Limit { get; set; }
       public Employee[] Employees;
        

        public void AddEmployees( int employee)
        {
            int[] Employees = new int[5];
            for (int i = 0; Employees.Length < Limit; i++)
            {
                Employees[Employees.Length - 1] = employee;
                Employees[i] = i;
                System.Console.WriteLine(Employees[i]);
                return;
            }
        }
        public Employee[] GetEmployees() => Employees;
    }
}
