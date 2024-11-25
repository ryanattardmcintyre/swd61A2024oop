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

BooksRepository myBooksRepository = new BooksRepository(dbContext);
CategoriesRepository myCategoriesRepository = new CategoriesRepository(dbContext);

//Code that will actually keeps on being repeated depending on the selection of the user

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
            Console.WriteLine("2. Search book");
            Console.WriteLine("3. List book reservations history");
            Console.WriteLine("4. Add a book - requires admin login");
            Console.WriteLine("5. Update a book - requires admin login");
            Console.WriteLine("6. Delete a book - requires admin login");
            Console.WriteLine("7. Top 5 that have been borrowed the most");
            Console.WriteLine("8. Top 5 users that have borrowed the most");
            menu1Choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (menu1Choice)
            {
                case 1:
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

                case 2:
                  
                  //  var list = myBooksRepository.GetAllBooks("keyword");

                    break;

                case 3:
                    break;

                case 4:
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

                case 5:
                    break;

                case 6:break;
                case 7:break;
                case 8:break;
            }

            break;

        case 2: //Reservations management
            Console.WriteLine("1. Reserve a book - requires log in");
            Console.WriteLine("2. Return a book");
            break;

        case 3: //Members Management
            Console.WriteLine("1. Add member");
            Console.WriteLine("2. See list of books borrowed by member");

            break;
        }

} while (mainMenuChoice != 4);

Console.WriteLine("Click on any key to terminate...");
Console.ReadKey();


// this needs some restructuring









Console.ReadKey();
