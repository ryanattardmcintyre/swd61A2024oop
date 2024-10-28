using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_RelationshipsTCA2023
{
    //Relationship between Passenger and Flight: Association


    public class Passenger
    {
        public string Passport { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
         public DateTime Dob { get; set; }

        public string Nationality { get; set; }
        public string Photo { get; set; }



        public Ticket BuyTicket(Flight flight, int ticketNo, string seat, string row, CategoryType category)
        {
            Ticket t = new Ticket(this);
            t.SeatNo = seat;
            t.Row = row;
            t.Category = category;
            t.No = ticketNo;
            t.FlightNo = flight.Number;

            return t;
        }
    }
}
