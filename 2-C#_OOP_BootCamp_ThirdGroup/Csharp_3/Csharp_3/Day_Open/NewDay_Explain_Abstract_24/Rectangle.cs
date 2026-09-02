using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.NewDay_Explain_Abstract_24
{
    class Rectangle : Shap
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) 
        {
            Width = width;
            Height = height;
        } 
        public override double GetArea()
        {
            return Width * Height;  
        }
    }
       
}
