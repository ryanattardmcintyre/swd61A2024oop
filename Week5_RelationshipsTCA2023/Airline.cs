using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_RelationshipsTCA2023
{
    public class Airline
    {
        public string Name { get; set; }
        public List<Flight> Flights { get; set; }
        public void AddFlight(Flight f) => Flights.Add(f);
    }
}
