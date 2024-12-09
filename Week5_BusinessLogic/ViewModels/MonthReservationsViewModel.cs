using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_BusinessLogic.ViewModels
{
    public class MonthReservationsViewModel
    {
        public string Month { get; set; }   //save the name 
        public int MonthId { get; set; }
        public int TotalReservations { get; set; }
    }
}
