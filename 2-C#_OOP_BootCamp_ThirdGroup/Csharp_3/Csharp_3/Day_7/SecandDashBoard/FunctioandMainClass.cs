using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_7.SecandDashBoard
{
     class FunctioandMainClass
    {

        //static void Main(string[] args)
        //{
        //    int ch;
 
        //    do
        //    {
        //        Console.WriteLine($"Welcome TO Our V2 Of Our System To Combain All Simple apps using void Functions \n" +
        //                          "pls Choose App's Number \n" +
        //                          "1.Employss Salary Info  \n" +
        //                          "2.Student Percentage Sys\n" +
        //                          "3.Patient Bmi Calc \n" +
        //                          "4.Month's Days Counter \n" +
        //                          "5.Exit...");
        //        ch = int.Parse(Console.ReadLine());

        //        switch (ch)
        //        {
        //            case 1:
        //                EmployeeClass employee = new EmployeeClass();

        //                object[] EmployeeInputs = employee.TakeEmployeeInputs();
        //                employee.PrintEmployeeSummary(employee.GetEmployeeSummary(EmployeeInputs[0].ToString(), Convert.ToDouble(EmployeeInputs[1])));

        //                break;
        //            case 2:
        //                StudentClass student = new StudentClass();

        //                object[] studentInputs = student. TakeStudentinputs();
        //                student.PrintStudentSummary(student.GetStudentSummary(studentInputs[0].ToString(), Convert.ToDouble(studentInputs[1]), Convert.ToDouble(studentInputs[2])));
        //                break;
        //            case 3:
        //                PatientClass patient = new PatientClass();

        //                object[] PatientInputs = patient. TakePatientinputs();
        //                patient. PrintPatientSummary(patient.GetPatientSummary(PatientInputs[0].ToString(), Convert.ToDouble(PatientInputs[1]), Convert.ToDouble(PatientInputs[2])));

        //                break;
        //            case 4:
        //                Console.WriteLine("Enter the month number (1-12):");
        //                int month = Convert.ToInt32(Console.ReadLine());
        //                Console.WriteLine( Months_Days_Counter(month));
        //                break;
        //            case 5:
        //                Console.WriteLine("Thanx ");
        //                break;
        //            default:
        //                Console.WriteLine("Invalid  Number");
        //                break;
        //        }

        //    } while (ch != 5);
        //}
 
        static string Months_Days_Counter(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                       return "This month has 31 days.";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    return "This month has 30 days.";
                    break;
                case 2:
                    return "this month has 28 or 29 days depending on leap year";  
                    break;
                default:
                    return "Invalid month Number";
                    break;
            }
        }
     }
}
