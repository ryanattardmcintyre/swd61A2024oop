using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_BusinessLogic.Exceptions
{
    public class CategoryNotFoundException: Exception
    {
        //this specifies a default message
        public CategoryNotFoundException(): base("Category input falls out of range and therefore doesn't exist") { }

        //this allows any developer (inc yourself) who's using this class change the message
        public CategoryNotFoundException(string message): base(message) { }
    }
}
