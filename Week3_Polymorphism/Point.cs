using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    /*
     * You need to create 3 classes
     * 
     * 
     * Point > int x, int y
     * Circle > Point. double radius; double FindPerimeter(), double FindArea()
     * [3D] Sphere > Circle. int z; FindPerimeter(), FindArea(), FindVolume()
     * [3D] Cylinder > Sphere. int z, double height; FindPerimeter(), FindArea(), FindVolume()
     * 
     */
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
}
