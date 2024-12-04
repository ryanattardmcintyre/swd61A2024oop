using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DataLayer;

namespace Week5_BusinessLogic
{
    public class MembersRepository
    {
        //in the constructor we are injecting an instance of the database
        //so libararyDbContext is an abstraction of the database
        public MembersRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        private LibraryDbContext _libraryDbContext;


        public void Register(Member m)
        {
            if (GetMember(m.Username) != null)
            { //username was already used
                //throw an exception to signal some message

                throw new Exception("Username exists");
            }
            else
            {
                _libraryDbContext.Members.Add(m); //this adds it in memory
                _libraryDbContext.SaveChanges(); //this saves it into the persisent database storage
            }
        }

        public Member GetMember(string username)
        {
            return _libraryDbContext.Members.SingleOrDefault(x => x.Username == username);
        }


        /// <summary>
        /// returns true if the credentials are authenticated
        /// returns false if the username and password do not match
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            if( _libraryDbContext.Members.SingleOrDefault(x => x.Username == username  && x.Password == password) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //BooksRepository
        public List<Book> GetBooks(string username)
        {
            var listOfReservations = _libraryDbContext.Reservations.Where(x => x.MemberFK == username); 
            //filtering in the reservations by the username
            var listOfBooksPertainingToTheReservationsAbove =  listOfReservations.Select(x=>x.Book).ToList();
            //we return a list of Books by calling the Select and choose the columns/properties you would like to return

            //Select Books.* from Books
            //inner join Reservations on Reservations.BookFK equals Books.Isbn
            //inner join Members on Reservations.MemberFK equals Members.Username
            //where Members.Username = 'username'

            return listOfBooksPertainingToTheReservationsAbove;

        }

        //BooksRepository/ ReservationsRepository
        public void BorrowABook(Reservation r)
        {
            r.DateBooked= DateTime.Now;

            //checking that the book to borrow is actually available
            bool isBookAvailable = true;
            //1/12/2024 +7 days = 8/12/2024
            //4/12/2024
            int count = _libraryDbContext.Reservations.Count(x => x.BookFK == r.BookFK && x.DateBooked.AddDays(x.DaysBookedFor) > r.DateBooked);

            if (count <= 0) //means that book is available
            {
                     _libraryDbContext.Reservations.Add(r);
                    _libraryDbContext.SaveChanges();  
            }
            else //book is not available
            {
                throw new Exception("Book is not available");
            }


             
        }
    }
}
