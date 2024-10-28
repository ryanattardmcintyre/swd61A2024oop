using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Composition
{
    public class House
    {
        //A house cannot be instantiated
        //UNLESS you first instantiate a Room
        //and pass it as a parameter in the constructor
        //of House
        public House(Room r) {
            Rooms = new List<Room>();
            Rooms.Add(r);
        }

        public List<Room> Rooms { get;set; }
    }
}
