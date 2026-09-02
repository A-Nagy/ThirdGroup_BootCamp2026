using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3.Day_Open
{
    abstract class Person
    {
 
        public string Name { get; set; }
        public Person(string name )
        {
            Name = name;
        }
        public abstract string GetInfo();


    }
}
