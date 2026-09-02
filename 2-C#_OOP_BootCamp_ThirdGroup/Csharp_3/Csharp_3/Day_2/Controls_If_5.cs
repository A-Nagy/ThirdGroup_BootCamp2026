using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3
{
    class Controls_If_5
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Enter Your name ");
        //    //string name = Console.ReadLine();
        //    //Console.WriteLine("Pls Enter Your Age ");
        //    //int age = Convert.ToInt32(Console.ReadLine());

        //    //if (age >= 20)
        //    //{
        //    //    Console.WriteLine("you Can Employee");
        //    //}
        //    //else if (age >= 15)
        //    //{
        //    //    Console.WriteLine("you are studen");
        //    //}
        //    //else if (age >= 10)
        //    //{
        //    //    Console.WriteLine("you are Child");
        //    //}
        //    //else 
        //    //{
        //    //    Console.WriteLine("you are J");
        //    //}
        //    /*
        //     ## ✅ Task 1: Employee Salary Classification
        // **Objective:**
        //- Ask the user to enter their name and monthly salary.
        //- Display name, monthly salary, and annual salary.
        //- Classify salary as:
        //- 15,000 or more → "High Salary"
        //- 10,000 or more → "Normal Salary"
        //- 5,000 or more → "Low Salary"
        //- Less than 5,000 → "Very Low Salary"
        //     */

        //    ////  Declare variables
        //    //  string employeeName;
        //    //  double monthlySalary;
        //    //  double annualSalary;

        //    //  //Get user input
        //    //  Console.Write("Enter your name: ");
        //    //  employeeName = Console.ReadLine();
        //    //  Console.Write("Enter your monthly salary: ");
        //    //  monthlySalary = Convert.ToDouble(Console.ReadLine());

        //    //  //Calculate annual salary
        //    //  annualSalary = monthlySalary * 12;

        //    //  //Display results
        //    //  Console.WriteLine("===============================");
        //    //  Console.WriteLine("Task 1: Employee Salary Check");
        //    //  Console.WriteLine("===============================");
        //    //  Console.WriteLine("Employee Name:  " + employeeName);
        //    //  Console.WriteLine("Monthly Salary: " + monthlySalary);
        //    //  Console.WriteLine("Annual Salary:  " + annualSalary);

        //    //  if      (monthlySalary >= 15000)
        //    //  {
        //    //      Console.WriteLine("High Salary");
        //    //  }
        //    //  else if (monthlySalary >= 10000)
        //    //  {
        //    //      Console.WriteLine("Normal Salary");
        //    //  }
        //    //  else if (monthlySalary >= 5000)
        //    //  {
        //    //      Console.WriteLine("low Salary");
        //    //  }
        //    //  else
        //    //  {
        //    //      Console.WriteLine("Very Low Salary");
        //    //  }


        //    /*
        //     * 
        //     # ✅ Task 2: Student Result Checker
        //     **Objective:**
        //     - Ask the student to enter their name, mark, and full mark.
        //     - Calculate percentage.
        //     - Classify grade based on percentage:
        //       - 85% or more → "Excellent"
        //       - 75% or more → "Very Good"
        //       - 65% or more → "Good"
        //       - 50% or more → "Pass"
        //       - Below 50% → "Failed"
        //    */

        //    ////Declare variables
        //    //string studentName;
        //    //double Marks;
        //    //double Full_Marks;
        //    //double Percentage;
        //    ////Get user input
        //    //Console.Write("Enter your name: ");
        //    //studentName = Console.ReadLine();
        //    //Console.Write("Enter your marks: ");
        //    //Marks = Convert.ToDouble(Console.ReadLine());
        //    //Console.Write("Enter full marks: ");
        //    //Full_Marks = Convert.ToDouble(Console.ReadLine());
        //    //Calculate percentage
        //    //Percentage = (Marks / Full_Marks) * 100;

        //    //Display results
        //    //Console.WriteLine("===============================");
        //    //Console.WriteLine("Task 2: Student Percentage Calculator");
        //    //Console.WriteLine("===============================");
        //    //Console.WriteLine("Student Name: " + studentName);
        //    //Console.WriteLine("Marks: " + Marks);
        //    //Console.WriteLine("Full Marks: " + Full_Marks);
        //    //Console.WriteLine("Percentage: " + Percentage + "%");
        //    //if (Percentage >= 85)
        //    //{
        //    //    Console.WriteLine("Excellent");
        //    //}
        //    //else if (Percentage >= 75)
        //    //{
        //    //    Console.WriteLine("Very Good");
        //    //}
        //    //else if (Percentage >= 65)
        //    //{
        //    //    Console.WriteLine("Good");
        //    //}
        //    //else if (Percentage >= 50)
        //    //{
        //    //    Console.WriteLine("pass");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Failed");
        //    //}
        //    /*
        //     ## ✅ Task 3: Patient BMI Status
        //           **Objective:**
        //        - Ask the patient to enter their name, height (in meters), and weight (in kg).
        //        - Calculate BMI using:
        //          BMI = weight / (height * height)
        //        - Classify BMI as:
        //          - Less than 18.5 → "Underweight"
        //          - 18.5 to less than 25 → "Normal Weight"
        //          - 25 to less than 30 → "Overweight"
        //          - 30 or more → "Obese"
        //     */

        //    //Console.WriteLine("the Patient Name is : ");
        //    //string patientName = Console.ReadLine();
        //    //Console.WriteLine("the Patient Height is : ");
        //    //double height = Convert.ToDouble(Console.ReadLine());
        //    //Console.WriteLine("the Patient Weight is : ");
        //    //double weight = Convert.ToDouble(Console.ReadLine());

        //    //double BMI = weight / (height * height);

        //    //Console.WriteLine("===============================");
        //    //Console.WriteLine("Task 3: Patient BMI Calculator");
        //    //Console.WriteLine("===============================");
        //    //Console.WriteLine("Patient Name: " + patientName);
        //    //Console.WriteLine("Height: " + height + "M");
        //    //Console.WriteLine("Weight: " + weight + "KG");
        //    //Console.WriteLine("BMI: " + BMI);
        //    //if (BMI < 18.5)
        //    //{
        //    //    Console.WriteLine("Underweight");
        //    //}
        //    //else if (BMI < 25)
        //    //{
        //    //    Console.WriteLine("Normal Weight");
        //    //}
        //    //else if (BMI < 30)
        //    //{
        //    //    Console.WriteLine("Overweight");
        //    //}
        //    //else 
        //    //{
        //    //    Console.WriteLine("Obese");
        //    //}





        //}
    }
}
