using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_7.SecandDashBoard
{
     class StudentClass
    {
        public object[] TakeStudentinputs()
        {
            Console.Write("Enter Student Name  ");
            string eName = Console.ReadLine();
            Console.Write("Enter Student Mark  : ");
            double Marks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter full marks: ");
            double Full_Marks = Convert.ToDouble(Console.ReadLine());

            return new object[] { eName, Marks, Full_Marks };
        }
        public double GetPercentage(double Marks, double Full_Marks)
        {
            return ((Marks / Full_Marks) * 100);
        }
        public string GetGrade(double Marks, double Full_Marks)
        {
            double percentage = GetPercentage(Marks, Full_Marks);

            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        public string[] GetStudentSummary(string Name, double Marks, double Full_Marks)
        {
            return new string[] { "The Student Name IS : " + Name,
                                  "The Student Marks : "   + Marks,
                                  "The Student Full Marks : " + Full_Marks,
                                  "The Student Percentage : " + GetPercentage(Marks, Full_Marks) + "%",
                                  "The Student Grade : "      + GetGrade(Marks, Full_Marks) };
        }
        public void PrintStudentSummary(string[] summary)
        {
            foreach (string s in summary)
            {
                Console.WriteLine(s);
            }
        }

    }
}
