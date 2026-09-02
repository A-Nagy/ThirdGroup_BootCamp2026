using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_6.Solve_Simple_Calc
{
     class CalC_Proccess_19_1
    {
        //4 proccess + - * /

        public static double Static_Sum_Return(double Num1 , double Num2) //paramters
        {            
            return Num1 + Num2;
        }

        public static double Static_Sub_Return(double Num1, double Num2)
        {      
            return Num1 - Num2;
        }

        public static double Static_Multi_Return(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
        public static double Static_Div_Return(double Num1, double Num2)
        {  
            if (Num2 == 0) 
            { 
                Console.WriteLine("you Try To Divid on zero");
                return 0;
            }
            else
            {
                return Num1 / Num2;

            }
         
        }

    }
}
