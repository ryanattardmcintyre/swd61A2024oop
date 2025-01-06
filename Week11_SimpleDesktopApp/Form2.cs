using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week5_BusinessLogic;
using Week5_DataLayer;

namespace Week11_SimpleDesktopApp
{
    public partial class Form2 : Form
    {
        private readonly LibraryDbContext _dbContext;
        public Form2(LibraryDbContext dbContext)
        {
            InitializeComponent();

            _dbContext = dbContext;

            //populate the comboBox

            CategoriesRepository categoriesRepository = new CategoriesRepository(dbContext);

            var list = categoriesRepository.GetCategories();

            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember= "Name"; //"Name" is the property of the Category being inserted in the cmb
            cmbCategories.ValueMember = "Id"; //"Id" is the property of the Category being used to be returned and evaluated,
                                              //once the user chooses a category from the cmb

            RefreshList();
        }
        private void RefreshList()
        {
            BooksRepository booksRepository = new BooksRepository(_dbContext);
            var myBookList = booksRepository.GetAllBooks();

            var myViewModelList = myBookList.Select(x => new
            {
                BookName = x.Name,
                Isbn = x.Isbn,
                CategoryName = x.Category.Name
            });


            dataGridView1.DataSource = myViewModelList.ToList();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //code that will add the book into the db
            try
            {
                BooksRepository booksRepository = new BooksRepository(_dbContext);
                Book myBook = new Book();
                myBook.Isbn = Convert.ToInt32(txtIsbn.Text);
                myBook.Name = txtName.Text;
                myBook.CategoryFK = Convert.ToInt32(cmbCategories.SelectedValue);

                booksRepository.AddBook(myBook);

                //refresh the list on screen by fetching the list of books once again
                RefreshList();

                MessageBox.Show("Book was added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: Book was not added successfully because " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BooksRepository booksRepository = new BooksRepository(_dbContext);
            var filteredBookList = booksRepository.GetAllBooks(txtSearch.Text);
            

            var myViewModelList = filteredBookList.Select(x => new
            {
                BookName = x.Name,
                Isbn = x.Isbn,
                CategoryName = x.Category.Name
            });


            dataGridView1.DataSource = myViewModelList.ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BooksRepository booksRepository = new BooksRepository(_dbContext);
            booksRepository.DeleteBook(Convert.ToInt32(txtDelete.Text));


            MessageBox.Show("Book was deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshList();
        }
    }
}
