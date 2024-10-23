using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week4_ClassRelationships.Composition
{
    public class Room
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public string Name { get; set; }
    }
    public class Kitchen : Room
    {
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double LengthOfKitchen { get; set; }
        public bool Island { get; set; }
    }
    public class Bedroom : Room
    {
        public double BedLength { get; set; }
        public double BedWidth { get; set; }
        public bool Ensuit { get; set; }
    }
}
