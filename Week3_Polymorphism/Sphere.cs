using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    /*
 *      * Circle > Point. double radius; double FindPerimeter(), double FindArea()
 * [3D] Sphere > Circle. int z; FindPerimeter(), FindArea(), FindVolume()
 * [3D] Cylinder > Sphere. int z, double height; FindPerimeter(), FindArea(), FindVolume()
 * 
 * 
 * 
 * Volume of a sphere:
V = (4/3)πr3
Circumference of a sphere:
C = 2πr
Surface area of a sphere:
A = 4πr2
 */
    public class Sphere : Circle //sphere is a circle
    {
        public int Z { get; set; }
        public override double FindPerimeter()
        {
            return base.FindPerimeter();
        }

        public override double FindArea()
        {
            return 4 * base.FindArea();
        }

        public virtual double FindVolume()
        {
            return (4 / 3) * (Math.PI * Math.Pow(Radius, 3));
        }

    }
}
