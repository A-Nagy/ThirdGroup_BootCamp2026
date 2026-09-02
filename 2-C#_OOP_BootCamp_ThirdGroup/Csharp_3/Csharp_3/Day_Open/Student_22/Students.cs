using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Student_22
{   
     class Students : Person
    {
        /*
         * 
         * **Student**
         - Properties: `Name`, `Mark`, `FullMark`
         - Functions: 
          - `GetPercentage()` → calculates result percentage
          - `GetGrade()` → returns grade based on percentage
         */

   
         double _mark;
         double _fullMark;

    
        public double Mark 
        { 
            get => _mark;
            set => _mark = value;
        }
        public double FullMark 
        { 
            get => _fullMark; 
            set => _fullMark = value; 
        }

        public Students(string name, double mark, double fullmark): base(name)
        {
         
            Mark = mark;
            FullMark = fullmark;
        }
        public double GetPercentage()
        {
            return (Mark / FullMark) * 100;
        }
        public string GetGrade() 
        {            
            double precentage = GetPercentage();

            //if (precentage >= 90)
            //{ return "A"; }
            //else if (precentage >= 80)
            //{ return "B"; }
            //else if (precentage >= 70)
            //{ return "C"; }
            //else if (precentage>=60 )
            //{ return "D"; }
            //else
            //{ return "F"; }


            return precentage >= 90 ? "A" :
                   precentage >= 80 ? "B" :
                   precentage >= 70 ? "C" :
                   precentage >= 60 ? "D" : "F";
        }

        public override string GetInfo()
        {
            return  $"Student Name : {Name}\n" +
                    $"Student Mark : {Mark}\n" +
                    $"Student FullMark :{FullMark}\n" +
                    $"Student Precentage : {GetPercentage()} %\n" +
                    $"Student Grade : {GetGrade()}" ;      
         }
    }
}
