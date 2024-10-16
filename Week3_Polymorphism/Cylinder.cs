using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    public class Cylinder: Sphere //cylinder is a sphere
    {
        public double Height { get; set; }
        public override double FindArea()
        {
            //  2πrh + 2(πr2)
            return (2*Math.PI*Radius*Height) + (2*Math.PI*Radius*Radius);
        }

        public override double FindPerimeter()
        {
            //2(2r + h)

            return 2 * ((2 * Radius) + Height);
        }

        public override double FindVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }
}
