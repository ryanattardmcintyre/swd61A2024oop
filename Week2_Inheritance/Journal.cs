using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week2_Inheritance
{
    //Inheritance is denoted by :<base class>
    //base class is the class we are inheriting from
    //When you inherit a class you are also inheriting (making available) the public members & the protected members in that class
    public class Journal: Book
    {
        //in reality, there are more properties declared and made available here even though they are hidden
        public int IssueNo { get; set; }
        public int Month { get; set; }


        public Journal(): base() //we are making a call to constructor of the base class i.e. Book
        {
            //here within the Journal class i can access the PROTECTED field called
            //unlike trying to access it from an external non-inheriting class
            available = true;

        }

        public Journal(string isbn, int issueNo, int month) : base(isbn) //runs the constructor declared inside the same class
        {
            Month = month;
            IssueNo = issueNo;
        }


        public override void Print()
        {
            base.Print(); //this will execute Book.Print()
            Console.Write($" Issue No: {IssueNo}, Month: {new DateTime(Year, Month, 1).ToString("MMMM")}");


        }



    }
}
