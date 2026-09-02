using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Employee_21
{
     class Employees : Person, IPrintable 
    {
        
        //Fields
 
        double _salary;

        //Properties
     
        public double Salary 
        {
            get { return _salary; }
            set { _salary = value; }

        }

        //Constractor
        public Employees(string name , double salary ) 
            :base(name) 
        {
          
            Salary = salary;
        }


        //Functions
        // ✅ الطريقة الثانية: تعتمد على الخصائص الداخلية للكائن

        public virtual double GetNetSalary()
        {
            return Salary;
        }

        public override string GetInfo()
        {
            return $"Employee Name is : {Name}\n" +
                   $"Employee Satalry is {GetNetSalary()}\n";    
        }


        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }
        public string GetAnnualSalaryLevel()
        {
            double annualSalary = CalculateAnnualSalary();
            if (annualSalary < 50000)
            {
                return "Low";
            }
            else if (annualSalary >= 50000 && annualSalary < 100000)
            {
                return "Medium";
            }
            else
            {
                return "High";
            }
        }

        public void PrintDetails()
        {
             Console.WriteLine($"Employee Name is : {Name}\n" +
                   $"Employee Satalry is {GetNetSalary()}\n") ;
        }





        // ✅ الطريقة الاولي: تعتمد على قيمة تمرر لها (parameter)
        //public string GetAnnualSalaryLevel(double annualSalary)
        //{
        //    if (annualSalary < 50000)
        //    {
        //        return "Low";
        //    }
        //    else if (annualSalary >= 50000 && annualSalary < 100000)
        //    {
        //        return "Medium";
        //    }
        //    else
        //    {
        //        return "High";
        //    }
        //}




    }
}
