using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DataLayer;

namespace Week5_BusinessLogic
{
    /*
     * is to hold behaviours (methods) that will allow us to connect with 
     * the databse to read and write data
     * 
     * CRUD operations
     * Create
     * Read
     * Update
     * Delete
     * 
     * i.e. to help me in managing the data related to Books directly with the database
     * also dedicate the class only to Books data
     * 
     */ 
    public class BooksRepository { 

        //assume that the LibraryDbContext instance is going to be instantiated in another
        //centralized place (ideally in Program.cs) and passed on to here where i can
        //carry out CRUD operations on the Books table in the database
        public BooksRepository(LibraryDbContext libraryDbContext) 
        {
            _libraryDbContext = libraryDbContext;
        }

        private LibraryDbContext _libraryDbContext;

        
        //the write operations Add, Update, Delete all require you to SaveChanges()
        //SaveChanges at the end commits the changes to the database
        public void AddBook(Book book) {
            
            _libraryDbContext.Books.Add(book);
            _libraryDbContext.SaveChanges();

        }
        public void UpdateBook(Book book) {
            var originalBook = GetBook(book.Isbn); //first we get the old book record
            if (originalBook != null) //if it is not null, it exists so we can update it
            {
                originalBook.Name = book.Name; //we update the name
                originalBook.CategoryFK= book.CategoryFK; // we update the category 
                _libraryDbContext.SaveChanges(); //save back the new changes onto the old record
            }
        }

        public void DeleteBook(int isbn) { 
            if(GetBook(isbn) != null) //if it is not null, it found the book i.e. it exists
            {
                _libraryDbContext.Books.Remove(GetBook(isbn));
                _libraryDbContext.SaveChanges();
            }
        }

        public List<Book> GetAllBooks() {
            return _libraryDbContext.Books.ToList();    
        }

        public Book GetBook(int isbn) {
            //module: Linq-to-entities
            //Where
            //SingleOrDefault, FirstOrDefault .....return ONE single book or nothing/null
            return _libraryDbContext.Books.SingleOrDefault(book => book.Isbn == isbn);

            //not using LINQ - to - entities
            //foreach (var book in _libraryDbContext.Books)
            //{
            //    if (book.Isbn == isbn) return book;
            //}
            //return null;
        }

        //static polymorphism i.e. overloading the method
        //static polymorphism- 2 or more methods/constructors with
        //                     the same name however they have different parameter types
        public List<Book> GetAllBooks(string keyword)
        {
            //Select * From Books Where Name like '%keyword%'
            return _libraryDbContext.Books.Where(x => x.Name.Contains(keyword)).ToList();
        }

        public List<Book> GetAllBooks(int category)
        {
            return _libraryDbContext.Books.Where(x => x.CategoryFK == category).ToList();
        }




    }
}
