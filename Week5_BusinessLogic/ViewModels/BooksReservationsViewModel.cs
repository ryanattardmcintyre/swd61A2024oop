using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_BusinessLogic.ViewModels
{
    public class BooksReservationsViewModel
    {
        public string BookTitle { get; set; }
        public int TotalReservations { get; set; }
    }

    public class MembersReservationsViewModel
    {
        public string MemberUsername { get; set; }
        public int TotalReservations { get; set; }
    }
}
