using Week5_DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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


//Code that will actually keeps on being repeated depending on the selection of the user
Console.WriteLine("1. See a list of books");
Console.WriteLine("2. Search book");
Console.WriteLine("3. List book reservations history");

Console.WriteLine("4. Add a book");
Console.WriteLine("5. Update a book");
Console.WriteLine("6. Delete a book");

Console.WriteLine("7. Top 5 that have been borrowed the most");
Console.WriteLine("8. Top 5 users that have borrowed the most");




