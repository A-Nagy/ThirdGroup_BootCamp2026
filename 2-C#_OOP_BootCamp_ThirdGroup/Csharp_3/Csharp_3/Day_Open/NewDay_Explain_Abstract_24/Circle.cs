using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.NewDay_Explain_Abstract_24
{

    class Circle : Shap
    {
        public double Raduis { get; set; }
        public Circle(double raduis)
        {
            Raduis = raduis;
        }
        public override double GetArea()
        {
            return Math.PI * Raduis * Raduis;

        }
    }
}
