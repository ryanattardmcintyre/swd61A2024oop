using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Introduction
{

    //what is a class?
    //a class is a blueprint/template which defines a "thing" from the real-world by grouping
    //a set of related components/members/...
    internal class Person
    {
        //properties:
        //like attributes which best describe the class is about
        //like containers for the data that will be assigned/ accessed

        //rules to respect when defining a property
        //1. name is without spaces, symbols, numbers
        //2. names of properties must be in Pascal casing means that the name starts with a capital letter
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }

        //methods
        //methods are behaviours which the class can have
        //e.g. a method to validate some property
        //e.g. a method which regulates the data inside a particular property

        public string CapitalizeFullName()
        {
            return FullName.ToUpper();
        }


    }
}
