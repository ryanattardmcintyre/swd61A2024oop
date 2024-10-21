using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClassesAndInterfaces.Example1
{
    //notes:
    //1. Interfaces are created to be inherited
    //2. Interfaces cannot be instantiated (you cannot create an object of)
    //3. Unlike an abstract class, In an interface you cannot have implemented methods
    //4. You are forced to override methods in ordinary classes once inherited

    public interface IErrorList
    {
        List<Exception> Errors { get; set; }

        void LogErrors(Exception ex);
    }
}
