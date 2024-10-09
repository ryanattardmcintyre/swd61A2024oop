using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book myBook = new Book(); //a declaration and an initialization of Book at the same time/on the same line;

            Book myBook2; //declaration
            myBook2 = new Book(); //initialization because we are calling the constructor

            Book myBook3 = new Book("567890-3456"); //this constructor will assign immediately isbn into the field/property

            DateTime dt = new DateTime(2000, 1, 20);
            DateTime dt2 = new DateTime(2000, 1, 20, 1, 1, 1);
            



            //class: is allowing us to define the entity e.g. Book
            //object/instance: is allowing us to personalize the book
            Book b; //declaration of the object
            b = new Book(); //initialization of the object (creation of memory space that will hold data about b)
                            //            Book b1 = new Book(); //this in one line;


            Console.WriteLine("Input a name for the book");
            b.Name = Console.ReadLine();

            Console.WriteLine("Input an isbn for the book");
            b.Isbn = Console.ReadLine();

            Console.WriteLine("Input the year the book was published in");
            try
            {
                b.Year = Convert.ToInt32(Console.ReadLine());
            } 
            catch 
            {
                Console.WriteLine("Invalid year input");
            }


            //approach 1
           /* Console.WriteLine("1. Horror");
            Console.WriteLine("2. Fiction");
            Console.WriteLine("3. SciFi");
           */

            //approach 2
            string[] namesInTheGenreSet = Enum.GetNames(typeof(GenreType));
            for (int i = 0; i < namesInTheGenreSet.Length; i++)
            {
                Console.WriteLine($"{i+1}. {namesInTheGenreSet[i]}");
            }
            Console.WriteLine("Type the preferred Genre (number): ");
            b.Genre = (GenreType) Convert.ToInt32(Console.ReadLine());

            //to show back whatever the user has input on screen

            Console.WriteLine($"Name: {b.Name} Isbn: {b.Isbn} Year: {b.Year} " +
                $"Genre: { b.Genre } \n Book is {b.HowOldIsTheBook()} years old");
            Console.ReadKey();



        }
    }
}
