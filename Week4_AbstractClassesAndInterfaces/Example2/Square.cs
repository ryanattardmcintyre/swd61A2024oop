using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example2
{
    public class Square : Shape
    {
        public override double FindArea()
        {
            return Length * Length;
        }
        public override double FindPerimeter()
        {
            return (Length + Length) * 2;
        }
    }
    public class Rectangle: Square
    {
        public double Width { get; set; }
        public override double FindArea()
        {
            return Length * Width;
        }

        public override double FindPerimeter()
        {
            return (Length + Width) * 2;
        }
    }
}
