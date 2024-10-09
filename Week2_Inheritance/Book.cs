using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    //enum are predefined sets which you cannot dynamically modify
    public enum GenreType { Horror = 1, Fiction = 2, SciFi = 3, None = 4 }

    //a class is  a representation of an entity, which is often referred to as a template
    public class Book
    {
        //1. A constructor is there but hidden and you can declare it so as to unhide
        //2. When you see a constructor without parameters, that is the default constructor
        //3. A constructor is like a special method BUT without a return type
        //4. A constructor bears the same name as the class
        //5. A secondary use to a constructor is to initialize variable/fields/properties
        public Book()
        {
            available = true;
            HistoryOfIdsThatBorrowedTheBook = new List<string>(); //the list can start adding data i.e. idcard numbers
            name = "";
            Genre = GenreType.None;
        }

        public Book(string isbn) : this() //runs the constructor declared inside the same class
        {
            Isbn = isbn;
        }


        //Fields:
        //fields are the containers where data is actually stored
        private string name;
        private string author;
        protected bool available;

        //the properties are the characteristics that make up the book
        //through properties we can GET or SET values
        //property is like the gateway to access the field via getters and the setters
        //hence with properties i can control the access/filter the data that goes into or out of the field
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value.ToUpper();
            }
        }

        public string Author
        {
            get
            {
                string masked = "";
                for (int i = 0; i < author.Length; i++)
                {
                    masked += "*";
                }
                return masked;
            }

            set => author = value;
        }


        public int Year { get; set; }
        public string Isbn { get; set; }
        public string Publisher { get; set; }
        public GenreType Genre { get; set; }

        public List<string> HistoryOfIdsThatBorrowedTheBook { get; set; }

        public bool Available
        {
            get
            {
                return available;
            }
        }


        //methods:
        //are the behavour of a Book
        //syntax: <access modifier><return type (if any)><Name><list of parameters>
        public void Borrow(string isbn, string idCardNo)
        {
            if (Available)
            {
                available = false;
                HistoryOfIdsThatBorrowedTheBook.Add(idCardNo);
            }
        }

        public int HowOldIsTheBook()
        {
            return DateTime.Now.Year - Year;
        }


    }
}
