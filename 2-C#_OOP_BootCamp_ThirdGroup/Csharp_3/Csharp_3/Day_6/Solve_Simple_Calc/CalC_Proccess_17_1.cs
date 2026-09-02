using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_6.Solve_Simple_Calc
{
     class CalC_Proccess_17_1
    {
        //4 proccess + - * /

        public static void Static_Sum() 
        {
            Console.WriteLine("Pls Enter Your First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pls Enter Your Secand Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Result is : {num1+num2}");

        }

        public static void Static_Sub()
        {
            Console.WriteLine("Pls Enter Your First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pls Enter Your Secand Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Result is : {num1 - num2}");

        }

        public static void Static_Multi()
        {
            Console.WriteLine("Pls Enter Your First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pls Enter Your Secand Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Result is : {num1 * num2}");

        }
        public static void Static_Div()
        {
            Console.WriteLine("Pls Enter Your First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pls Enter Your Secand Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Result is : {num1 / num2}");

        }

    }
}
