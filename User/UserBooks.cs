using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserBooks : Form
    {
        // Colors
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);
        
        public UserBooks()
        {
            InitializeComponent();
            LoadBooks();
            SetActiveButton(btnQuanLySach); // Set Sách Của Tôi as active
        }

        private void dgvBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvBooks.Cursor = Cursors.Hand;
            }
        }

        private void dgvBooks_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvBooks.Cursor = Cursors.Default;
        }

        private void SetActiveButton(Button activeButton)
        {
            // Reset all buttons in the flow layout panel
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = SecondaryColor;
                }
            }
            // Set active button appearance
            if (activeButton != null)
            {
                activeButton.BackColor = PrimaryColor;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHome);
            MainUserForm mainUserForm = new MainUserForm();
            mainUserForm.Show();
            this.Close(); // Close UserBooks form
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLySach);
            // Already on UserBooks form, no action needed or refresh content if necessary
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLyNguoiDung);
            UserBorrow userBorrowForm = new UserBorrow();
            userBorrowForm.Show();
            this.Close(); // Close UserBooks form
        }

        private void LoadBooks()
        {
            // Sample data - replace with actual data access
            var books = new[]
            {
                new { 
                    Cover = (Image)null,
                    Title = "The Great Gatsby", 
                    Author = "F. Scott Fitzgerald", 
                    Published = new DateTime(1925, 4, 10), 
                    Status = "Available",
                    Actions = "View Details"
                },
                new { 
                    Cover = (Image)null,
                    Title = "To Kill a Mockingbird", 
                    Author = "Harper Lee", 
                    Published = new DateTime(1960, 7, 11), 
                    Status = "Available",
                    Actions = "View Details"
                },
                new { 
                    Cover = (Image)null,
                    Title = "1984", 
                    Author = "George Orwell", 
                    Published = new DateTime(1949, 6, 8), 
                    Status = "Borrowed",
                    Actions = "View Details"
                },
                new { 
                    Cover = (Image)null,
                    Title = "Pride and Prejudice", 
                    Author = "Jane Austen", 
                    Published = new DateTime(1813, 1, 28), 
                    Status = "Available",
                    Actions = "View Details"
                },
                new { 
                    Cover = (Image)null,
                    Title = "The Hobbit", 
                    Author = "J.R.R. Tolkien", 
                    Published = new DateTime(1937, 9, 21), 
                    Status = "Available",
                    Actions = "View Details"
                },
            };

            dgvBooks.DataSource = books;

            // Format columns if available
            if (dgvBooks.Columns.Count > 0)
            {
                dgvBooks.Columns["Published"].DefaultCellStyle.Format = "d MMM yyyy";
                dgvBooks.Columns["Status"].DefaultCellStyle.ForeColor = Color.Green;
                dgvBooks.Columns["Status"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgvBooks.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBooks.Columns["Actions"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBooks.Columns["Actions"].DefaultCellStyle.ForeColor = PrimaryColor;
                dgvBooks.Columns["Actions"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Underline);
                dgvBooks.Columns["Cover"].Width = 80;
                dgvBooks.Columns["Status"].Width = 100;
                dgvBooks.Columns["Actions"].Width = 120;
                dgvBooks.Columns["Published"].Width = 120;
            }
        }
    }
}
