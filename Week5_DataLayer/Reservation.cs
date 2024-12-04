using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_DataLayer
{
    public class Reservation
    {
        //we dont need to apply the Key attribute because the runtime assumes that Id is the primary key
        public int Id { get; set; }
        public int BookFK { get; set; }

        [ForeignKey("BookFK")]
        public virtual Book Book { get; set; } //navigational property i.e. connects the Reservations table to the Books table
                                                //through the navigational property we managed to get the columns from the Books table
                                                //meaning also that there was no need to write any inner join statements
                                                //Navigational properties however work only if you enable LazyLoading
        
        public DateTime DateBooked { get; set; }
        public int DaysBookedFor { get; set; }

        public string MemberFK { get; set; } 
        
        [ForeignKey("MemberFK")]
        public virtual Member Member { get; set; } //navigational proeprty connects the Reservations table to the Members table
    }
}
