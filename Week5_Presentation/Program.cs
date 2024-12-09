using Week5_DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Week5_BusinessLogic;

//code under this comment goes inside the Main (if you have a Main method)

//Code that should run once in the beginning

using var host = Host.CreateDefaultBuilder(args)
        .ConfigureServices((context, services) =>
        {
            // Register LibraryDbContext without additional options
            services.AddDbContext<LibraryDbContext>();
        })
        .Build();

// Create a scope to resolve and use the DbContext
using var scope = host.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<LibraryDbContext>();

// Ensure the database is created
//await dbContext.Database.EnsureCreatedAsync();

dbContext.Database.EnsureCreated();
Console.WriteLine("Database has been created (if it didn't already exist).");


//its a centralized place where to instantiate these repository classes which will allow us to call methods 
//that query or write data from and to the database withouth creating any extra/unneeded instances
BooksRepository myBooksRepository = new BooksRepository(dbContext);
CategoriesRepository myCategoriesRepository = new CategoriesRepository(dbContext);
MembersRepository myMembersRepository = new MembersRepository(dbContext);
ReservationsRepository myReservationsRepository = new ReservationsRepository(dbContext);

//Code that will actually keeps on being repeated depending on the selection of the user

string authenticatedUsername = "";

int mainMenuChoice = 0;
do
{
        Console.Clear();
        Console.WriteLine("1. Books");
        Console.WriteLine("2. Reservations");
        Console.WriteLine("3. Members");
        Console.WriteLine("4. Quit");
        mainMenuChoice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (mainMenuChoice)
        {
        case 1: //Books management
            int menu1Choice = 0;
            Console.WriteLine("1. See a list of books");
            Console.WriteLine("2. Search book by name");
            Console.WriteLine("3. Search book by category"); 
            Console.WriteLine("4. Add a book - requires admin login");
            Console.WriteLine("5. Update a book - requires admin login");
            Console.WriteLine("6. Delete a book - requires admin login");
          
            menu1Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (menu1Choice)
            {
                case 1://getting a list of books
                    var list = myBooksRepository.GetAllBooks();
                    Console.WriteLine("List of Books: " + list.Count);

                    Console.WriteLine();
                    foreach(var book in list)
                    {
                        Console.WriteLine($"Isbn: {book.Isbn}, Name: {book.Name}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();

                    break;

                case 2: //Search Book

                    Console.Clear();
                    Console.WriteLine("What do you want to search for? ");
                    string keyword = Console.ReadLine();
                    var searchedBooksList = myBooksRepository.GetAllBooks(keyword);

                    Console.WriteLine();
                    foreach (var book in searchedBooksList)
                    {
                        Console.WriteLine($"Isbn: {book.Isbn}, Name: {book.Name}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();


                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Which category you would like to list books of?");
                    var myCategoriesForSearch = myCategoriesRepository.GetCategories();
                    foreach (var c in myCategoriesForSearch)
                    {
                        Console.WriteLine($"{c.Id}. {c.Name}");
                    }


                    int selectedCategory = Convert.ToInt32(Console.ReadLine());
                    var searchedBooksListCase3 = myBooksRepository.GetAllBooks(selectedCategory);

                    Console.WriteLine();
                    foreach (var book in searchedBooksListCase3)
                    {
                        Console.WriteLine($"Isbn: {book.Isbn}, Name: {book.Name}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();


                    break;

                case 4: //Adding a book
                    Book myBook = new Book();
                    Console.WriteLine("Input isbn:");
                    myBook.Isbn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input name:");
                    myBook.Name = Console.ReadLine();
                     
                    Console.WriteLine("Input category:");
                    var myCategories = myCategoriesRepository.GetCategories();
                    foreach (var c in myCategories)
                    {
                        Console.WriteLine($"{c.Id}. {c.Name}");
                    }

                    myBook.CategoryFK = Convert.ToInt32(Console.ReadLine());
                    myBooksRepository.AddBook(myBook);
                    
                    Console.WriteLine();
                    Console.WriteLine("Book added into the db...");
                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();

                    break;

                case 5: //Update a book
                    Book myBookToBeUpdated = new Book();
                    Console.WriteLine("Input isbn of the book you would like to update:");
                    myBookToBeUpdated.Isbn = Convert.ToInt32(Console.ReadLine());

                    if (myBooksRepository.GetBook(myBookToBeUpdated.Isbn) == null)
                    {
                        Console.WriteLine("This isbn doesn't exist in our database");
                    }
                    else
                    {
                        Console.WriteLine("Input name:");
                        myBookToBeUpdated.Name = Console.ReadLine();

                        Console.WriteLine("Input category:");
                        var myCategoriesForUpdate = myCategoriesRepository.GetCategories();
                        foreach (var c in myCategoriesForUpdate)
                        {
                            Console.WriteLine($"{c.Id}. {c.Name}");
                        }

                        myBookToBeUpdated.CategoryFK = Convert.ToInt32(Console.ReadLine());
                        myBooksRepository.UpdateBook(myBookToBeUpdated);

                        Console.WriteLine();
                        Console.WriteLine("Book updated into the db...");
                    }
                 
                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();

                    break;

                case 6: //Deleting a book

                    Console.Clear();
                    Console.WriteLine("Input isbn of book to delete");
                    //suggestion: check whether isbn exists before deleting.

                    myBooksRepository.DeleteBook(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Book was deleted...");

                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();


                    break;
 
            }

            break;

        case 2: //Reservations management - stats (hint: we have to use group by)
            Console.WriteLine("1. Show No. of Reservations per Category");
            Console.WriteLine("2. Show No. Of Reservations per Month");
            Console.WriteLine("3. Show No. Of Reservations per Month per Category");
            Console.WriteLine("4. List History of Reservations For All Users");
            Console.WriteLine("5. List History of Reservations For All Users For a Given Year");
            Console.WriteLine("6. Top 5 books that have been borrowed the most");
            Console.WriteLine("7. Top 5 users that have borrowed the most books");

            Console.WriteLine("input choice");
            int case2_choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(case2_choice)
            {
                case 1:
                    var listOfRervationsPerCategory = myReservationsRepository.GetTotalReservationsPerCategory();

                    Console.WriteLine("Category\t\t\t\tTotal Reservations");
                    Console.WriteLine();
                    foreach (var item in listOfRervationsPerCategory)
                    {
                        Console.WriteLine($"{item.CategoryTitle}\t\t\t\t{item.TotalReservations}");
                    }


                    break;

                case 2:
                    var listOfRervationsPerMonth = myReservationsRepository.GetTotalReservationsPerMonth();

                    Console.WriteLine("Month\t\t\t\tTotal Reservations");
                    Console.WriteLine();
                    foreach (var item in listOfRervationsPerMonth)
                    {
                        Console.WriteLine($"{item.Month}\t\t\t\t{item.TotalReservations}");
                    }

                    break; ;
            }

            Console.WriteLine("Press a key to continue to the main menu...");
            Console.ReadKey();


            break;

        case 3: //Members Management
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. See list of books borrowed by member");
            Console.WriteLine("4. Borrow a book");
            Console.WriteLine("5. Get how many books per month were rented by member for a specific year");
            Console.WriteLine("6. Get the avg no of books borrowed per category throughout the years");
            //e.g. in 2023 - Science 10 books
            //e.g. in 2024 - Science 20 books
            // avg = 15

            int menu3Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (menu3Choice)
            {
                case 1:

                    Member newMember = new Member();
                    Console.WriteLine("Input username");
                    newMember.Username = Console.ReadLine();
                    Console.WriteLine("Input password");
                    newMember.Password = ReadPassword();

                    Console.WriteLine("Input first name");
                    newMember.FirstName = Console.ReadLine();
                    
                    Console.WriteLine("Input last name");
                    newMember.LastName = Console.ReadLine();

                    myMembersRepository.Register(newMember);
                    Console.WriteLine("Registration complete");

                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();

                    break;

                case 2:

                    Console.WriteLine("Input username");
                    string username = Console.ReadLine();
                    
                    Console.WriteLine("Input password");
                    string password = ReadPassword();

                    bool authentication =myMembersRepository.Login(username, password);
                    if (authentication == true)
                    {
                        //the user logged in successfully ...
                        authenticatedUsername = username;
                        Console.WriteLine("Logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine("Invalid log in");
                    }
                    break;

                case 3:

                    if (authenticatedUsername == "")
                    {
                        Console.WriteLine("Access denied");
                    }
                    else
                    {
                        var borrowedBooks = myMembersRepository.GetBooks(authenticatedUsername);
                        Console.WriteLine("*********** Borrowed Books so far ***********");
                        Console.WriteLine();
                        foreach (var book in borrowedBooks)
                        {
                            Console.WriteLine($"Isbn: {book.Isbn}, Name: {book.Name}");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press a key to continue to the main menu...");
                        Console.ReadKey();
                    }

                    break;

                case 4:
                    Console.Clear();
                    if (authenticatedUsername == "")
                    {
                        Console.WriteLine("Access denied");
                    }
                    else
                    {
                        Console.WriteLine("Borrowing a book....");
                        Console.WriteLine("Which book? input isbn");
                        int isbnOfBookToBorrow = Convert.ToInt32(Console.ReadLine());

                        Reservation myReservation = new Reservation();
                        myReservation.BookFK = isbnOfBookToBorrow;
                        myReservation.MemberFK = authenticatedUsername;

                        Console.WriteLine("Specify the days you intend to keep the book");

                        myReservation.DaysBookedFor = Convert.ToInt32(Console.ReadLine());

                        //in db
                        //book 1001 -> 1/12/2024 for 7 days

                        myMembersRepository.BorrowABook(myReservation);
                        Console.WriteLine("Book was reserved. come and collect it. you need to return the book on the " +
                            (DateTime.Now.AddDays(myReservation.DaysBookedFor).ToShortDateString()));

                    }
                    Console.WriteLine();
                    Console.WriteLine("Press a key to continue to the main menu...");
                    Console.ReadKey();

                    break;
            }



            break;
        }

} while (mainMenuChoice != 4);

Console.WriteLine("Click on any key to terminate...");
Console.ReadKey();


// this needs some restructuring









Console.ReadKey();








//this needs to be pasted in the internal class Program
static string ReadPassword()
{
    string password = string.Empty;
    ConsoleKey key;

    do
    {
        var keyInfo = Console.ReadKey(intercept: true); // Read a key without displaying it
        key = keyInfo.Key;

        if (key == ConsoleKey.Backspace && password.Length > 0)
        {
            // Remove the last character from the password and the console
            password = password[0..^1];
            Console.Write("\b \b"); // Move back, overwrite with space, and move back again
        }
        else if (!char.IsControl(keyInfo.KeyChar))
        {
            // Append the character to the password and display a masking character
            password += keyInfo.KeyChar;
            Console.Write("*");
        }
    }
    while (key != ConsoleKey.Enter); // Continue until Enter is pressed

    return password;
}