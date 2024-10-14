using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            do
            {
                Console.WriteLine("Choose between ");
                Console.WriteLine("1. Book");
                Console.WriteLine("2. Journal");
                Console.WriteLine("3. Scientific Journal");

                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice <1 || choice >3);


            Book b = null ;

            switch(choice)
            {
                case 1:
                    b = new Book();

                    break;

                case 2:
                    Console.WriteLine("Input issue no");
                    int issueNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input month (as a number)");
                    int month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input isbn");
                    string isbn = (Console.ReadLine());

                    b = new Journal(isbn, issueNo, month); //this is allowed because Journal is a Book


                    break;

                case 3:
                    Console.WriteLine("Input issue no");
                    int issueNo2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input month (as a number)");
                    int month2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input isbn");
                    string isbn2 = (Console.ReadLine());

                    Console.WriteLine("Input field of study");
                    string field = Console.ReadLine();

                    b = new ScientificJournal(field, isbn2, issueNo2, month2);
                    break;

                default:
                    b =new Book();  //the code will resort to this in case the choice is not 1 to 3;
                    break;
            }

            Console.WriteLine("Input name");
            b.Name = Console.ReadLine();

            Console.WriteLine("Input Äuthor");
            b.Author = Console.ReadLine();

            Console.WriteLine("Input Year");
            b.Year =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine();


            //Polymorphism: is the ability for the program to be able to identify the right inherited method to call

            b.Print(); //since Journal/ScientificJournal both inherit from Book, they get to inherit Print()

            Console.WriteLine("Hit a key to continue");
            Console.ReadKey(); 
        }
    }
}
