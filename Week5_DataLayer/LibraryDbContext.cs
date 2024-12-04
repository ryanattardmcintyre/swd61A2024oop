using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_DataLayer
{
    //this class here is an abstraction of the database
    //so whatever i declare inside this class will be eventually translated into a database
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } //this list will be converted into a database table
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server = is the name of the installation server or the ip address of the database
            //Database = the name of the database used (even if not created)
            //Trusted_Connection = it specifies whether the sql server has to trust this connection - if yes it will use
            //                     your windows credentials; if no you have to specify user id & password
            //TrustServerCertificate (may be necessary)

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-O0I9A16V\SQLEXPRESS;Database=SWD61A2024LibraryDb;Trusted_Connection=True;");


            optionsBuilder.UseLazyLoadingProxies(); //if you don't enable this, navigational properties are not populated with
                                                    //data from child/parent tables automatically
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity relationships or constraints if necessary
        }
    }
}

