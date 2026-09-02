using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.NewDay_Explain_Abstract_24
{
    abstract class Shap
    {
        public abstract double GetArea();
        public void Display() 
        {
            Console.WriteLine("Shap Called");
        }
    }
}
