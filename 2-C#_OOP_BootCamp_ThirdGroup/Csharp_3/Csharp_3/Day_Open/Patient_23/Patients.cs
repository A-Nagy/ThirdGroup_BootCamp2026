using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Patient_23
{
     class Patients :Person
    {

       
         double _Pheight;
         double _Pweight;
        public Patients(string name , double height, double weight):base(name)
        {

            Pheight = height;
            Pweight = weight;
        }

       
        public double Pheight 
        { 
            get => _Pheight;
            set => _Pheight = value;
        }
        public double Pweight 
        { 
            get => _Pweight;
            set => _Pweight = value; 
        }

        public double GetBMI() 
        {
            return Pweight/(Pheight* Pheight);
        }
        public string GetBodyStatus() 
        {
            double Bmi = GetBMI();
            return Bmi <= 18.5 ? "Under Weight"   :
                   Bmi <= 25   ? "Normal Weight"  :
                   Bmi <= 30   ? "Over Weight "   : "Obasety";
        }
        public override string GetInfo()
        {
            return $"Patient Name   : {Name}\n" +
                   $"Patient Height : {Pheight}\n" +
                   $"Patient Weight :{Pweight}\n" +
                   $"Patient BMI    : {GetBMI()}\n" +
                   $"Patient Grade  : {GetBodyStatus()}";
        }
    }
}
