using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example1
{
    //notes:
    //1. Abstract classes are created to be inherited
    //2. Abstract classes cannot be instantiated (you cannot create an object of)
    //3. Abstract classes hold implemented and non-implemented members (properties + methods)
    //4. With Abstract methods you are forced to override them unlike virtual methods in ordinary classes

    //Log is a record which goes in this registry which is a timeline of events + descriptions
     public abstract class Log
    {
        public int Id { get; set; } 
        public string Description { get; set; }

        public DateTime Timestamp { get; set; }

        public string Origin { get; set; }

        public string User { get; set; }


        //when you don't have enough details of what to implement in a particular behavour
        //but at the same time some other behaviours/members are well-known
        //its suitable to use an Abstract class
        public abstract void Save();
        


        public override string ToString()
        {
            return $"Id: {Id}; Description: {Description}; " +
                $"Timestamp: {Timestamp.ToString("dd/MM/yyyy HH:mm:ss:f")}; Origin: {Origin}; User: {User}";
        }


    }
}
