using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_RelationshipsTCA2023
{
    public class Flight
    {
        public string Number { get; set; }
        public string AirporDeparture { get; set; }

        public string AirportDestination { get; set; }

        public int Capacity { get; set; }

        public DateTime Departure { get; set; }
        public DateTime EstimatedArrival { get; set; }

        public List<Ticket> Tickets { get; set; }

        public bool AddATicket(Ticket ticket)
        {
            foreach(Ticket t in Tickets)
            {
                if (t.SeatNo == ticket.SeatNo && t.Row == ticket.Row)
                {
                    return false;
                }
            }

            Tickets.Add(ticket);
            return true;

        }
    }
}
