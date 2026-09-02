using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_7.SecandDashBoard
{
     class PatientClass
    {

        public   object[] TakePatientinputs()
        {
            Console.Write("Enter Patient Name  ");
            string pName = Console.ReadLine();
            Console.Write("Enter Patient Hight  : ");
            double hight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Patient Wight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            return new object[] { pName, hight, weight };
        }
        private  double   GetBMI(double hight, double wight)
        {
            return wight / (hight * hight);
        }
        private  string   BodyStatus(double hight, double wight)
        {
            double BMI = GetBMI(hight, wight);
            if (BMI < 18.5)
            {
                return "Underweight";
            }
            else if (BMI < 25)
            {
                return "Normal Weight";
            }
            else if (BMI < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
        public   string[] GetPatientSummary(string Name, double hight, double wight)
        {
            return new string[] { "The Patient Name IS : " + Name,
                                  "The Patient Height : "   + hight,
                                  "The Patient Weight : " + wight,
                                  "The Patient BMI : " + GetBMI(hight, wight)  ,
                                  "The Patient Body Status : "      + BodyStatus(hight, wight) };
        }
        public   void     PrintPatientSummary(string[] summary)
        {
            foreach (string s in summary)
            {
                Console.WriteLine(s);
            }
        }


    }
}
