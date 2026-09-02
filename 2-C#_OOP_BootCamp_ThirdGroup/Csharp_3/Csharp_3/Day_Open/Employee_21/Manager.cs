using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Employee_21
{
    class Manager : Employees
    {
        public double Bonus { get; set; }

        public Manager(string name , double salary , double bonus) :base(name,salary)
        {
            Bonus = bonus;
        }

        public override double GetNetSalary() 
        {
           return Salary + Bonus;
        }
         

    }
}
