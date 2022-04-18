using System;
using Employee.Models;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe();
            employe.No = 4;
            employe.Fullname = "arif";
            employe.Positions = "Hesabat";

            Company company = new Company { Name = "Amazon", Limit = 3 };
            company.AddEmployees(employe);
        }

    }
}
