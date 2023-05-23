using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Triangle
    {
       // Properties
       public double Height { get; set; }
       public double Base { get; set; }

       // Constaractors
       public Triangle(double height, double baseParameter)
        {
            Height = height;
            Base = baseParameter;
        }

       // Methods 
       public double Area()
       {
            double result = 0;

            result = Base * Height / 2;

            return result;
       }

       public double Perimetr()
        {
            double result = 0;

            result = Base + Height + Math.Sqrt(Math.Pow(Base , 2) + Math.Pow(Height, 2));

            return result;
        }
    }
}
