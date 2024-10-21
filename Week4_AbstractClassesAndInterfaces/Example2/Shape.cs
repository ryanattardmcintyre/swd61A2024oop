using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example2
{
    //if you need to declare properties in the base class...
    //...then you have to declare abstract class not an interface
    public abstract class Shape : I2DCalculations, IShape
    {
        public double Length { get; set; }
         
        public abstract double FindArea();
        public abstract double FindPerimeter();
        

        string IShape.Print()
        {
            return $"Shape has a length of {Length}";
        }
    }
}
