using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Task1_EmployeesSystem
{
    class TestTask1
    {
        //static void Main(string[] args)
        //{
        //    Employee employee = new Employee("AHmad", 20000);
        //    Console.WriteLine(employee.Name);
        //    Console.WriteLine(employee.CalculateAnnualSalary());
        //    Console.WriteLine(employee.GetSalaryLevel(employee.CalculateAnnualSalary()));

        //}
    }
    public interface ISalaryLevel
    {
        string GetSalaryLevel(double annualSalary);
    }
    public abstract class EmployeeBase 
    {
        string name;
        double monthlySalary;
        public string Name { get => name; set => name = value; }
        public double MonthlySalary { get => monthlySalary; set => monthlySalary = value; }
        public EmployeeBase(string name ,double mSalary) 
        {
            Name = name;
            MonthlySalary = mSalary;
        }
        public abstract double CalculateAnnualSalary();
 
    }
    public class Employee : EmployeeBase, ISalaryLevel
    {
       public Employee(string name, double mSalary) : base(name, mSalary) { }
       
       public override double CalculateAnnualSalary()
        {
            return MonthlySalary * 12;
        }

        public string GetSalaryLevel(double annualSalary)
        {
            return annualSalary >= 180000 ? "High Salary"   :
                   annualSalary >= 120000 ? "Normal Salary" :
                   annualSalary >= 6000   ? "Low Salary "   : "Very Low Salary ";
        }
    }

}
