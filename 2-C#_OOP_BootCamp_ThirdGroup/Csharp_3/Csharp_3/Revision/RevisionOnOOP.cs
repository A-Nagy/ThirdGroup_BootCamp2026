using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Revision
{
     class RevisionOnOOP
    {
        /*
- *Abstraction*   Employee class is abstract and hides implementation details using abstract method GetSalary() 
- *Encapsulation* Private fields (name, salary, etc.) with public properties (getters/setters) 
- *Inheritance*   EmployeeBasic and EmployeeHourly inherit from Employee |
- *Polymorphism*  GetSalary() is overridden differently in each derived class.
                   Base class reference holds derived class objects 
         */
        //static void Main(string[] args)
        //{
        //    EmployeeHourly EH = new EmployeeHourly("", 0,0);
        //    EH.GetSalary();

        //    EmployeeBasic EB = new EmployeeBasic("", 0, 0);
        //    EB.GetSalary();

        //}

        public abstract class Employee
        {
            
            string name;
            double salary;

            public string Name { get => name; set => name = value; }
            public double Salary { get => salary; set => salary = value; }

            public Employee(string Names , double MSalary) 
            {
                this.Name   = Name;
                Salary      = MSalary ;
            }

            public abstract double GetSalary();
     

        }
        public class EmployeeHourly : Employee
        {
            double overtime;
            public double Overtime { get => overtime; set => overtime = value; }

            public EmployeeHourly(string Names, double MSalary,double overt) : base(Names, MSalary)
            {
                this.Overtime = overt;
            }

            public override double GetSalary()
            {
                return Salary + Overtime;
            }
        }
        public class EmployeeBasic : Employee
        {
            double commission;

            public EmployeeBasic(string Names, double MSalary, double commission ) : base(Names, MSalary)
            {
                Commission = commission;
            }

            public double Commission { get => commission; set => commission = value; }

            public override double GetSalary()
            {
                return Salary + Commission;

            }
        }

    }
    /*
     * 
### 🔹 Employee (Abstract Base Class)
- *Fields (Encapsulated)*:
  - name
  - salary
- *Methods*:
  - AnnualSalary() → *Abstract method*, implemented by subclasses
- *Purpose*: Provides a base structure for all types of employees.

### 🔹 EmployeeBasic (Inherits Employee)
- *Additional Field*:
  - commission
- *Method Override*:
  - AnnualSalary() returns (salary * 12) + commission

### 🔹 EmployeeHourly (Inherits Employee)
- *Additional Field*:
  - overtime
- *Method Override*:
  - AnnualSalary() returns (salary * 12) + overtime

### 🔹 TestEmployee (Main Class)
- Creates instances of EmployeeBasic and EmployeeHourly
- Demonstrates *runtime polymorphism*
- Prints annual salaries

     */
}
