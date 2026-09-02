using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Employee_21
{
     class Developer : Employees
    {
        public double OverTimeHours { get; set; }
        public double HourLyRate
        { get; set;}
        public Developer(string name ,double salary,  double overTimeHours, double hourLyRate)
            : base(name,salary)
        {
            OverTimeHours = overTimeHours;
            HourLyRate = hourLyRate;
        }

        public override double GetNetSalary()
        {
            return base.GetNetSalary() + (OverTimeHours * HourLyRate);
        }
       
    }
 
}
