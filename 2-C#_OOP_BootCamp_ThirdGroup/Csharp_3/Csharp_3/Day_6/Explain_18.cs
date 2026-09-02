using Csharp_3.Day_6.Solve_Simple_Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_6
{
     class Explain_18
    {
        //static void Main(string[] args) 
        //{
        //    int Ch;
         
        //        Console.WriteLine($"Choose Your Process From List \n" +
        //                          $"1. +.\n" +
        //                          $"2. -.\n"                                
        //                       );
        //        Ch = int.Parse(Console.ReadLine());
        //        switch (Ch)
        //        {
        //            case 1:

        //            Static_Sum();
        //            double avrage =  11 / 2.0; 
        //            Console.WriteLine(avrage);
        //                break;
        //            case 2:

        //            // instance = Non_Static  
        //            Static_Instance_18 samar = new Static_Instance_18();
        //             samar. Instance_Sub();
        //            break;
      
        //        }
           
        //}

        //1.Belongs to the class itself
        //2.Called without creating an object.
        //3.ClassName.FunctionName();
        public static void Static_Sum()
        {
            Console.WriteLine("Pls Enter Your First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pls Enter Your Secand Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Result is : {num1 + num2}");

        }
 
        //1.Belongs to a specific object (instance of class)
        //2.Requires creating an object to use.
        //3.ObjectName.FunctionName();
        public void Instance_Sub()
        {
            Console.WriteLine("Pls Enter Your First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pls Enter Your Secand Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Result is : {num1 - num2}");

        }


        //void  one of Function Types , return the Secand Type  , double, int 

        public static double Static_Sum_Return()
        {
            Console.WriteLine("Pls Enter Your First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Pls Enter Your Secand Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Result is : {num1 + num2}");

            return num1 + num2;
        }


        /*
         ## 🧠 Why Use `return`?

| Feature                 | `void` method                           | `return` method                    |
|--------------------------|----------------------------------------|-------------------------------------|
| Reusability              | ❌ Must be rewritten or copied          | ✅ Can be reused anywhere           |
| Testability              | ❌ Hard to test output                  | ✅ Easy to test with inputs/outputs |
| Flexibility              | ❌ Output always printed to console     | ✅ Return value can be reused       |
| Clean code               | ❌ More side effects                    | ✅ Fewer side effects               |
       
         */

        /*
         
## 🧠 Why Use Parameters?

| Without Parameters               | With Parameters                      |
|----------------------------------|---------------------------------------|
| Requires user input from console| Input can come from any source        |
| Tightly coupled to Console       | Reusable and testable with any data   |
| Not suitable for unit testing    | ✅ Easy to test                        |
| Harder to maintain/extend        | ✅ Clean and modular                   |

         
         */


    }
}
