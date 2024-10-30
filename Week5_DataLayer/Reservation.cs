using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_DataLayer
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BookFk { get; set; }

        public DateTime DateBooked { get; set; }
        public int DaysBookedFor { get; set; }
    }
}
