using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    public class ScientificJournal : Journal
    {

        public ScientificJournal() { }

        public ScientificJournal(string field, string isbn, int issueNo, int month) : base(isbn, issueNo, month)
        {
            FieldOfStudy = field;
        }
        

        public string FieldOfStudy { get; set; }

        public override void Print()
        {
            base.Print(); //it will call first Journal.Print()
            Console.WriteLine($" Field of study: {FieldOfStudy}");
        }
    }
}
