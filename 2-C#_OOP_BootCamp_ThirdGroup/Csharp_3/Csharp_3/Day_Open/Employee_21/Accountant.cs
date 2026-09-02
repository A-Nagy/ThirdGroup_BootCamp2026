using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Employee_21
{
     class Accountant : Employees
    {
        public double TaxDeduction { get; set; }
        public Accountant(string name, double salary, double taxDeduction ) : base(name, salary)
        {
            TaxDeduction = taxDeduction;
        }
        public override double GetNetSalary()
        {
            return Salary - TaxDeduction;
        }


    }
}
