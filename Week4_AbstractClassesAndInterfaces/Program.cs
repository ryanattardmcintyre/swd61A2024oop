using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_AbstractClassesAndInterfaces.Example1;

namespace Week4_AbstractClassesAndInterfaces
{
    internal class Program
    {
        //abstract classes: classes which allow implemented and non-implemented members

        //interfaces: components which do not allow any implemented stuff. they exist only to be inherited
        static void Main(string[] args)
        {

            List<Log> myLogs = new List<Log>();

            FileLog myLog = new FileLog();
            myLog.FilePath = "Log.txt";

            myLog.Id= 1;
            myLog.Timestamp= DateTime.Now;
            myLog.Description = "Testing logs";
            myLog.Origin = "Program.cs";
            myLog.User = "Ryan";

            myLogs.Add(myLog);

            System.Threading.Thread.Sleep(3000); //make the application wait for 3 sec

            EmailLog myEmailLog = new EmailLog();
            myEmailLog.Smtp = "smtp.gmail.com";
            myEmailLog.SmtpId = "username";
            myEmailLog.SmtpPassword = "password";
            //you have to set the rest of the properties

            myEmailLog.Id = 2;
            myEmailLog.Timestamp = DateTime.Now;
            myEmailLog.Description = "Testing email logs";
            myEmailLog.Origin = "Program.cs";
            myEmailLog.User = "Ryan";
            myLogs.Add(myEmailLog);


            foreach (Log log in myLogs)
            {
                log.Save();
            }
        }
    }
}
