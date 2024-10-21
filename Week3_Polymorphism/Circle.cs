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
     */
    public class Circle: Point //circle is a point
    {
        public double Radius { get; set; }

        public virtual double FindPerimeter()
        {
            return Math.PI * Radius * 2;
        }

        public double FindArea()
        {
            return Math.PI * Radius * Radius;
            //return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
