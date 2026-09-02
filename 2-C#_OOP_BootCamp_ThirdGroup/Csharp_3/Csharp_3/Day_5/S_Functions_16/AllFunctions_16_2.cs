using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_5.S_Functions_16
{
    class AllFunctions_16_2
    {
       public  static void CpanlStringDisplay()
        {
            Console.WriteLine("pls Choose number of your Apps 1-4 ");
            Console.WriteLine(" 1: Employee Salary Check\n" +
                              " 2: Student Percentage Calculator \n" +
                              " 3: Patient BMI Calculator \n" +
                              " 4: Month Days \n" +
                              " 5: Exit ...");
        }
       public  static void EmployeeSystemInfo()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Task 1: Employee Salary Check");
            Console.WriteLine("===============================");
            //  Declare variables
            string employeeName;
            double monthlySalary;
            double annualSalary;

            //Get user input
            Console.Write("Enter your name: ");
            employeeName = Console.ReadLine();
            Console.Write("Enter your monthly salary: ");
            monthlySalary = Convert.ToDouble(Console.ReadLine());

            //Calculate annual salary
            annualSalary = monthlySalary * 12;

            //Display results

            Console.WriteLine("Employee Name:  " + employeeName);
            Console.WriteLine("Monthly Salary: " + monthlySalary);
            Console.WriteLine("Annual Salary:  " + annualSalary);

            if (monthlySalary >= 15000)
            {
                Console.WriteLine("High Salary");
            }
            else if (monthlySalary >= 10000)
            {
                Console.WriteLine("Normal Salary");
            }
            else if (monthlySalary >= 5000)
            {
                Console.WriteLine("low Salary");
            }
            else
            {
                Console.WriteLine("Very Low Salary");
            }

        }
       public static void StudentSystemInfo()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Task 2: Student Percentage Calculator");
            Console.WriteLine("===============================");

            // Declare variables
            string studentName;
            double Marks;
            double Full_Marks;
            double Percentage;
            //Get user input
            Console.Write("Enter your name: ");
            studentName = Console.ReadLine();
            Console.Write("Enter your marks: ");
            Marks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter full marks: ");
            Full_Marks = Convert.ToDouble(Console.ReadLine());
            // Calculate percentage
            Percentage = (Marks / Full_Marks) * 100;

            //  Display results

            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Marks: " + Marks);
            Console.WriteLine("Full Marks: " + Full_Marks);
            Console.WriteLine("Percentage: " + Percentage + "%");
            if (Percentage >= 85)
            {
                Console.WriteLine("Excellent");
            }
            else if (Percentage >= 75)
            {
                Console.WriteLine("Very Good");
            }
            else if (Percentage >= 65)
            {
                Console.WriteLine("Good");
            }
            else if (Percentage >= 50)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }
       public static void PatientBMICalculator()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Task 3: Patient BMI Calculator");
            Console.WriteLine("===============================");

            Console.WriteLine("the Patient Name is : ");
            string patientName = Console.ReadLine();
            Console.WriteLine("the Patient Height is : ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the Patient Weight is : ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (height * height);


            Console.WriteLine("Patient Name: " + patientName);
            Console.WriteLine("Height: " + height + "M");
            Console.WriteLine("Weight: " + weight + "KG");
            Console.WriteLine("BMI: " + BMI);
            if (BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (BMI < 25)
            {
                Console.WriteLine("Normal Weight");
            }
            else if (BMI < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }
       public static void MonthDays()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Task 4: Month Days");
            Console.WriteLine("===============================");

            Console.WriteLine("Enter the month number (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month has 31 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month has 30 days.");
                    break;
                case 2:
                    Console.WriteLine("this month has 28 or 29 days depending on leap year");
                    break;
                default:
                    Console.WriteLine("Invalid month Number");
                    break;

            }
        }
    }
}
