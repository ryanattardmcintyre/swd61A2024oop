using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();

            Console.WriteLine("Name for journal:");
            myJournal.Name= "Test";

            myJournal.IssueNo = 1;
            myJournal.Month = 1;

            myJournal.Borrow("345678", "56789M");
      


           

        }
    }
}
