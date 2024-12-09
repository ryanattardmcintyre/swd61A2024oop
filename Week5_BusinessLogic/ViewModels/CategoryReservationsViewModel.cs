using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_BusinessLogic.ViewModels
{
    //a ViewModel is usually a class created to present something on screen e.g. CategoryReservationsViewModel
    //model is created to create the schema of the database //e.g. Book, Category, ...

    //viewmodel vs model; they are both there to hold the data, but one is to present then the data on screen, whilst
    //                    the model is used to represent a table from the database
    public class CategoryReservationsViewModel
    {
        public string CategoryTitle { get; set; }
        public int TotalReservations { get; set; }

    }
}
