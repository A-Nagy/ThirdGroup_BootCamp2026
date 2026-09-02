using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open.Room_20
{
     class Rooms
    {/*
           
        **Room**
   - Properties: `Length`, `Width`, `Height`
   - Function: `GetVolume()` → calculates room volume
 */


        //class
        //members are the variables, properties, methods . 
        //Class is a blueprint for creating objects.
        //It defines the properties and behaviors that the objects will have.

        //fields ==> Private Properties
        //fields are variables that are declared directly in a class
        //Fields can be of any type.
        //Fields can be declared with different access modifiers,such as public, private, protected, and internal.
        //Fields used to store data that is associated with an object or class.

       double _length;
       double _width;
       double _height;

        //Properties ==> public Properties
        //Spicial Method Used To Get And Set Values in Fields 
        public double Length 
        {
            get { return _length ; }
            set { _length = value <= 0 ? 0 : value ; }
        }
        public double Width 
        {
            get { return _width ; }
            set { _width = value <= 0 ? 0 : value; }
        }
        public double Height 
        {
            get { return _height; }
            set { _height = value <= 0 ? 0 : value; }
        }


        //Functions
        //Methods are functions that are defined within a class
        // are used to perform actions or operations on the data stored in the class .
        public double GetVolume()
        {
            return Length * Width ;
        }

        //Constractor 
        //Constartor is A Spicial Method
        //Constrator used To Initializes The Objects 
        public Rooms(double l , double w , double h) 
        {
                Length = l;
                Width  = w;
                Height = h;
        }

    }
}
