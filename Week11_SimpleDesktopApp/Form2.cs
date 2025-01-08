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
        private string _username;
        public Form2(LibraryDbContext dbContext, string username)
        {
            InitializeComponent(); //is a hidden method that runs to initialize the controls on screen. so trying to setting up
                                   // values inside controls which have not been initialized yet, will raise an exception

            _username = username;
            _dbContext = dbContext;

            //populate the comboBox

            CategoriesRepository categoriesRepository = new CategoriesRepository(dbContext);

            var list = categoriesRepository.GetCategories();

            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember= "Name"; //"Name" is the property of the Category being inserted in the cmb
            cmbCategories.ValueMember = "Id"; //"Id" is the property of the Category being used to be returned and evaluated,
                                              //once the user chooses a category from the cmb



            //Task to do:
            //1 Get a list of books from BooksRepository ...GetBooks
            //2 bind that list with cmbBooks
            
            BooksRepository booksRepository = new BooksRepository(_dbContext);
            var myBookList = booksRepository.GetAllBooks();

            var myViewModelList = myBookList.Select(x => new
            {
                Isbn = x.Isbn,
                ComboBoxContent = x.Name + " (" + x.Isbn +')'
            }).ToList();

            cmbBooks.DataSource = myViewModelList;
            cmbBooks.DisplayMember = "ComboBoxContent";
            cmbBooks.ValueMember = "Isbn";

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToTheLoginScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //this is referring to Form2

            //Main() ->>> Form1 (Login form) ->>> Form2
            //1. the Main() stops - everything will stop
            //2. the Form1 is closed - everything will stop
            //3. the Form2 is closed - only Form 2 is closed, Form1 and the Main method still run
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var ctrl in this.Controls) //looping in all the controls that were dragged and dropped on THIS form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //checking the type of control
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting ctrl (of type object) into a GroupBox, immediately we're hiding it
                }
            }
            
            grpAddBook.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls) //looping in all the controls that were dragged and dropped on THIS form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //checking the type of control
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting ctrl (of type object) into a GroupBox, immediately we're hiding it
                }
            }

            grpDeleteBook.Visible = true;
            grpDeleteBook.Location = new Point(12, 46);

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls) //looping in all the controls that were dragged and dropped on THIS form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //checking the type of control
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting ctrl (of type object) into a GroupBox, immediately we're hiding it
                }
            }

            grpListBooks.Visible = true;
            grpListBooks.Location = new Point(12, 46);
        }

        private void placeAReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls) //looping in all the controls that were dragged and dropped on THIS form
            {
                if (ctrl.GetType() == typeof(GroupBox)) //checking the type of control
                {
                    ((GroupBox)ctrl).Visible = false; //typecasting ctrl (of type object) into a GroupBox, immediately we're hiding it
                }
            }

            grpAddReservation.Visible = true;
            grpAddReservation.Location = new Point(12, 46);
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            Reservation myReservation = new Reservation();
            myReservation.DateBooked = DateTime.Now;

            //dtpReturnDate.Value

            //cmbBooks.SelectedValue.ToString()

            

        }
    }
}
