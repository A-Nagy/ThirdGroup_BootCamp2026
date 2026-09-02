using Csharp_3.Day_Open.Task1_EmployeesSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Task2_StudentSystem
{
      class TestTask2
    {
        //static void Main(string[] args)
        //{
        //    /*
        //     * - Create an **abstract class** `StudentBase` with:
        //            - Properties: `Name`, `Mark`, `FullMark`
        //            - Abstract Method: `GetPercentage()`
        //            - Create an **interface** `IGrading` with:
        //            - Method: `GetGrade(double percentage)`
        //            - Implement a class `Student` that inherits from `StudentBase` and implements `IGrading`.
        //             */
        //    /*
        //     * - Create an **abstract class** `PatientBase` with:
        // - Properties: `Name`, `Height`, `Weight`
        // - Abstract Method: `GetBMI()`
        // - Create an **interface** `IBodyStatus` with:
        // - Method: `GetStatus(double bmi)`
        // - Implement a class `Patient` that inherits from `PatientBase` and implements `IBodyStatus`.
        //     */
      
        //}


    }

    public abstract class StudentBase 
    {
         string _name;
         double _mark;
         double _Fullmark;
         
        public string Name { get => _name; set => _name = value; }
        public double Mark { get => _mark; set => _mark = value; }
        public double Fullmark { get => _Fullmark; set => _Fullmark = value; }

        public StudentBase(string name, double mark, double fullmark)
        {
            Name = name;
            Mark = mark;
            Fullmark = fullmark;
        }
 
        public abstract double GetPercentage();

    }
    public interface IGrading
    {
        string GetGrade(double percentage);
    }
    public class Student : StudentBase, IGrading
    {
        public Student(string name, double mark, double fullmark) : base(name, mark, fullmark)
        {
        }

     
        public string GetGrade(double percentage)
        {
            if (percentage >= 85) return "Excellent";
            else if (percentage >= 75) return "Very Good";
            else if (percentage >= 65) return "Good";
            else if (percentage >= 50) return "Pass";
            else return "Failed";
        }

        public override double GetPercentage()
        {
            return (Mark / Fullmark) * 100;
        }
    }
    // task 3
    public abstract class PatientBase
    {
        public string Name;
        public double Height;
        public double Weight;

        public PatientBase(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public abstract double GetBMI();
    }

    public interface IBodyStatus
    {
        string GetStatus(double bmi);
    }

    public class Patient : PatientBase, IBodyStatus
    {
        public Patient(string name, double height, double weight) : base(name, height, weight) { }

        public override double GetBMI()
        {
            return Weight / (Height * Height);
        }

        public string GetStatus(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Normal Weight";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }
    }

}
