using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_RelationshipsTCA2023
{
    //Relationship between Passenger and Ticket is : Composition
    public enum CategoryType { Business,Economy,SuperEconomy}
    public class Ticket
    {
        public Passenger Passenger { get; set; }
        public Ticket(Passenger passenger)
        { 
            Passenger = passenger;
        }

        public int No { get; set; }
        public string Passport { get; set; }
        public string Row { get; set; }
        public string SeatNo { get; set; }
        public CategoryType Category { get; set; }

        public string FlightNo { get; set; }


    }
}
