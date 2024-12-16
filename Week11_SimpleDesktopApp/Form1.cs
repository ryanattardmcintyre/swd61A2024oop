using Week5_BusinessLogic;
using Week5_DataLayer;

namespace Week11_SimpleDesktopApp
{
    public partial class Form1 : Form
    {
       
        private readonly LibraryDbContext _dbContext;

        public Form1(LibraryDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

            // You can now use _dbContext for database operations
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //this is an event ; its like a method which interacts with the GUI of a button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //check
            MembersRepository membersRepository = new MembersRepository(_dbContext);
            bool check = membersRepository.Login(username, password);

            if (check)
            {
                MessageBox.Show("Access allowed"); //its like Console.WriteLine()
            }
            else { 
                MessageBox.Show("Access denied");
            }
        }
    }
}