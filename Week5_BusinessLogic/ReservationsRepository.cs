using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_BusinessLogic.ViewModels;
using Week5_DataLayer;

namespace Week5_BusinessLogic
{
    public class ReservationsRepository
    {

        public ReservationsRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        private LibraryDbContext _libraryDbContext;

        /* 
         *  Console.WriteLine("1. Show No. of Reservations per Category");
            Console.WriteLine("2. Show No. Of Reservations per Month");
            Console.WriteLine("3. Show No. Of Reservations per Month per Category"); 
            Console.WriteLine("4. List History of Reservations For All Users");
            Console.WriteLine("5. List History of Reservations For All Users For a Given Year");
            Console.WriteLine("6. Top 5 books that have been borrowed the most");
            Console.WriteLine("7. Top 5 users that have borrowed the most books");
        */


        //Category Title | No. Of Reservations
        //Fiction        | 5 
        //Science        | 3


        public List<Reservation> GetReservationsForMember(string username)
        {
            return _libraryDbContext.Reservations.Where(x => x.MemberFK == username).OrderByDescending(x=>x.DateBooked).ToList();
        }

        public List<CategoryReservationsViewModel> GetTotalReservationsPerCategory()
        {
            //group by
            //Select Categories.Id, Categories.Title, Count(Reservations.Id)
            //from Reservations
            //inner join Books on Books.Isbn equals Reservations.BookFK
            //inner join Categories on Books.CategoryFK equals Categories.Id
            //group by Categories.Name, Categories.Id


            //linq-to-entites
            List<CategoryReservationsViewModel> list = 
                    _libraryDbContext.Reservations
                     .GroupBy(x=> new { CategoryId = x.Book.CategoryFK, CategoryTitle = x.Book.Category.Name })
                    .Select(x => new CategoryReservationsViewModel  {
                     CategoryTitle = x.Key.CategoryTitle,
                     TotalReservations = x.Count()
                    }).ToList();
          
            //raw linq
            /*var list2 = from r in _libraryDbContext.Reservations
                        join b in _libraryDbContext.Books
                        on r.BookFK equals b.Isbn
                        join c in _libraryDbContext.Categories
                        on b.CategoryFK equals c.Id
                        group c by c into g
                        select new CategoryReservationsViewModel()
                        {
                            CategoryTitle = g.Key.Name,
                            TotalReservations = g.Count()
                        };
           */

            return list.ToList();
        }

        //Month    | No. Of Reservations
        //January  | 2
        //February | 1
        //...

        //
        public List<MonthReservationsViewModel> GetTotalReservationsPerMonth()
        {
            //hint: group by the DateBooked Month
            List<MonthReservationsViewModel> list =
                   _libraryDbContext.Reservations.GroupBy(x => new {
                     MonthId = x.DateBooked.Month
                   } )

                   .Select(x => new MonthReservationsViewModel
                   {
                       MonthId = x.Key.MonthId,
                       Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x.Key.MonthId),
                       TotalReservations = x.Count()
                   }).
                   OrderBy(x => x.MonthId).
                   ToList();

            return list;
        }


       // Console.WriteLine("6. Top 5 books that have been borrowed the most");

        public List<BooksReservationsViewModel> GetTop5BorrowedBooks()
        {
            //a) to get all the reservations 
            //b) to group by the Book/ Book Isbn
            //c) to Select Book
            //d) sorting: OrderByDescending the Count of Reservations
            //e) var list = ....;    return list.Take(5);

             var list = _libraryDbContext.Reservations 
                  .GroupBy(x => new {Name= x.Book.Name, Isbn = x.Book.Isbn } ) //we are not allowed to group by a class data type
                  .Select(x => new BooksReservationsViewModel()
                  {
                      BookTitle =  x.Key.Name,
                      TotalReservations = x.Count()
                  })
                  .OrderByDescending(x => x.TotalReservations)
                  .Take(5)
                  .ToList();
            return list;
        }



        //    Console.WriteLine("7. Top 5 users that have borrowed the most books");

        public List<MembersReservationsViewModel> GetTop5MembersThatMadeTheMostReservations()
        {

            //a) to get all the reservations 
            //b) to group by the MemberFK
            //c) to Select Member
            //d) sorting: OrderByDescending the Count of Reservations
            //e) var list = ....;    return list.Take(5);


            /*
             * Date | Member | Book
             * 
             * group 1
             * 1st  | joe | 1
             * 2nd  | joe | 2
             * 3rd  | joe | 3
             * 
             * group 2
             * 1st | tom | 10
             * 1st | tom | 11
             * 
             */ 


            var list = _libraryDbContext.Reservations
              .GroupBy(x => x.Member.Username) //since we are not allowed to group by an entire Member object....
              .Select(x => new MembersReservationsViewModel()
              {
                  MemberUsername = x.Key, //consequently this changes as well
                  TotalReservations = x.Count()
              })
              .OrderByDescending(x => x.TotalReservations)
              .Take(5)
              .ToList();

            return list;


        }



    }
}
