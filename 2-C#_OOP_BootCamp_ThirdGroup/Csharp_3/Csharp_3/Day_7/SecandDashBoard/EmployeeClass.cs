using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_7.SecandDashBoard
{
     class EmployeeClass
    {
        public object[] TakeEmployeeInputs()
        {
            Console.Write("Enter Employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee monthly salary: ");
            double monthlySalary = Convert.ToDouble(Console.ReadLine());

            return new object[] { name, monthlySalary };
        }
         double GetAnnualSalary(double monthlySalary)
        {
            return monthlySalary * 12;
        }
         string GetSalaryLevel(double monthlySalary)
        {
            if (monthlySalary >= 15000)
            {
                return "High Salary";
            }
            else if (monthlySalary >= 10000)
            {
                return "Normal Salary";
            }
            else if (monthlySalary >= 5000)
            {
                return "Low Salary";
            }
            else
            {
                return "Very Low Salary";
            }
        }
        public string[] GetEmployeeSummary(string Name, double monthlySalary)
        {
            double annual = GetAnnualSalary(monthlySalary);
            string level = GetSalaryLevel(monthlySalary);

            return new string[] {"The Employee Name IS : "        + Name           ,
                                             "The Monthly Salary "  + monthlySalary ,
                                             "the Salary level is " + level         ,
                                             "The Annual Salary Is "+ annual        };
        }
        public void PrintEmployeeSummary(string[] sum)
        {
            foreach (string s in sum)
            {
                Console.WriteLine(s);
            }
        }

    }
}
