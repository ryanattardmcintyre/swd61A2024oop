namespace Week11_SimpleDesktopApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAddBook = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpListBooks = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpDeleteBook = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToTheLoginScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeAReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddReservation = new System.Windows.Forms.GroupBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnReserveBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpAddBook.SuspendLayout();
            this.grpListBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDeleteBook.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpAddReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddBook
            // 
            this.grpAddBook.Controls.Add(this.btnAddBook);
            this.grpAddBook.Controls.Add(this.cmbCategories);
            this.grpAddBook.Controls.Add(this.label3);
            this.grpAddBook.Controls.Add(this.txtName);
            this.grpAddBook.Controls.Add(this.label2);
            this.grpAddBook.Controls.Add(this.txtIsbn);
            this.grpAddBook.Controls.Add(this.label1);
            this.grpAddBook.Location = new System.Drawing.Point(49, 91);
            this.grpAddBook.Name = "grpAddBook";
            this.grpAddBook.Size = new System.Drawing.Size(624, 247);
            this.grpAddBook.TabIndex = 0;
            this.grpAddBook.TabStop = false;
            this.grpAddBook.Text = "Add a Book";
            this.grpAddBook.Visible = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(122, 186);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(94, 29);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(122, 141);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(223, 28);
            this.cmbCategories.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(427, 27);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(122, 52);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(427, 27);
            this.txtIsbn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isbn";
            // 
            // grpListBooks
            // 
            this.grpListBooks.Controls.Add(this.btnSearch);
            this.grpListBooks.Controls.Add(this.label4);
            this.grpListBooks.Controls.Add(this.txtSearch);
            this.grpListBooks.Controls.Add(this.dataGridView1);
            this.grpListBooks.Location = new System.Drawing.Point(714, 27);
            this.grpListBooks.Name = "grpListBooks";
            this.grpListBooks.Size = new System.Drawing.Size(984, 569);
            this.grpListBooks.TabIndex = 1;
            this.grpListBooks.TabStop = false;
            this.grpListBooks.Text = "List of Books";
            this.grpListBooks.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(835, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(173, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(634, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(847, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpDeleteBook
            // 
            this.grpDeleteBook.Controls.Add(this.btnDelete);
            this.grpDeleteBook.Controls.Add(this.txtDelete);
            this.grpDeleteBook.Controls.Add(this.label7);
            this.grpDeleteBook.Location = new System.Drawing.Point(124, 31);
            this.grpDeleteBook.Name = "grpDeleteBook";
            this.grpDeleteBook.Size = new System.Drawing.Size(624, 160);
            this.grpDeleteBook.TabIndex = 2;
            this.grpDeleteBook.TabStop = false;
            this.grpDeleteBook.Text = "Delete a book";
            this.grpDeleteBook.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(122, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Book";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(122, 52);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(427, 27);
            this.txtDelete.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Isbn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.reservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1717, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToTheLoginScreenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToTheLoginScreenToolStripMenuItem
            // 
            this.backToTheLoginScreenToolStripMenuItem.Name = "backToTheLoginScreenToolStripMenuItem";
            this.backToTheLoginScreenToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.backToTheLoginScreenToolStripMenuItem.Text = "Back to the Login Screen";
            this.backToTheLoginScreenToolStripMenuItem.Click += new System.EventHandler(this.backToTheLoginScreenToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.listToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeAReservationToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // placeAReservationToolStripMenuItem
            // 
            this.placeAReservationToolStripMenuItem.Name = "placeAReservationToolStripMenuItem";
            this.placeAReservationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.placeAReservationToolStripMenuItem.Text = "Place a reservation";
            this.placeAReservationToolStripMenuItem.Click += new System.EventHandler(this.placeAReservationToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // grpAddReservation
            // 
            this.grpAddReservation.Controls.Add(this.cmbBooks);
            this.grpAddReservation.Controls.Add(this.label5);
            this.grpAddReservation.Controls.Add(this.dtpReturnDate);
            this.grpAddReservation.Controls.Add(this.btnReserveBook);
            this.grpAddReservation.Controls.Add(this.label8);
            this.grpAddReservation.Location = new System.Drawing.Point(49, 369);
            this.grpAddReservation.Name = "grpAddReservation";
            this.grpAddReservation.Size = new System.Drawing.Size(624, 247);
            this.grpAddReservation.TabIndex = 4;
            this.grpAddReservation.TabStop = false;
            this.grpAddReservation.Text = "Place a Reservation";
            this.grpAddReservation.Visible = false;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(124, 58);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(479, 28);
            this.cmbBooks.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Return Date";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(122, 102);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(250, 27);
            this.dtpReturnDate.TabIndex = 5;
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.Location = new System.Drawing.Point(122, 171);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.Size = new System.Drawing.Size(181, 29);
            this.btnReserveBook.TabIndex = 4;
            this.btnReserveBook.Text = "Reserve book";
            this.btnReserveBook.UseVisualStyleBackColor = true;
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select Book";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 694);
            this.Controls.Add(this.grpAddReservation);
            this.Controls.Add(this.grpDeleteBook);
            this.Controls.Add(this.grpListBooks);
            this.Controls.Add(this.grpAddBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpAddBook.ResumeLayout(false);
            this.grpAddBook.PerformLayout();
            this.grpListBooks.ResumeLayout(false);
            this.grpListBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDeleteBook.ResumeLayout(false);
            this.grpDeleteBook.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAddReservation.ResumeLayout(false);
            this.grpAddReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpAddBook;
        private Button btnAddBook;
        private ComboBox cmbCategories;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtIsbn;
        private Label label1;
        private GroupBox grpListBooks;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Label label4;
        private TextBox txtSearch;
        private GroupBox grpDeleteBook;
        private Button btnDelete;
        private TextBox txtDelete;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem reservationsToolStripMenuItem;
        private ToolStripMenuItem placeAReservationToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem backToTheLoginScreenToolStripMenuItem;
        private GroupBox grpAddReservation;
        private Button btnReserveBook;
        private Label label8;
        private DateTimePicker dtpReturnDate;
        private Label label5;
        private ComboBox cmbBooks;
    }
}