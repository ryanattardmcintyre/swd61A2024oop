using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Classes
{
    //enum are predefined sets which you cannot dynamically modify
    public enum GenreType {Horror=1, Fiction=2, SciFi=3 }

    //a class is  a representation of an entity, which is often referred to as a template
    public class Book
    {
        //Fields:
        //fields are the containers where data is actually stored
        private string name;
        private string author;
        private bool available;

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

        public string Author { 
            get {
                string masked = "";
                for (int i = 0; i < author.Length; i++)
                {
                    masked += "*";
                }
                return masked;
            }
            
            set => author = value; }


        public int Year { get; set; }
        public string Isbn { get; set; }
        public string Publisher { get; set; }
        public GenreType Genre { get; set; }
        public bool Available { get {
                return available;
            }  }
   

        //methods:
        //are the behavour of a Book
        //syntax: <access modifier><return type (if any)><Name><list of parameters>
        public void Borrow(string isbn)
        {
            if (Available)
            {
                available = false;
            }
        }

        public int HowOldIsTheBook()
        {
            return DateTime.Now.Year - Year;
        }


    }
}
