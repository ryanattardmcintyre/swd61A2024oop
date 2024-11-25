using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_DataLayer;

namespace Week5_BusinessLogic
{
    //Repository classes are there to handle the data directly from/to the database

    public class CategoriesRepository
    {
        public CategoriesRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        private LibraryDbContext _libraryDbContext;

        public List<Category> GetCategories()
        {
            return _libraryDbContext.Categories.ToList();
        }

    }
}
