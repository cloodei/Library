using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadTableView("Users");
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            LoadTableView("Books");
        }

        private void btnManageBorrowRequests_Click(object sender, EventArgs e)
        {
            LoadTableView("BorrowRequests");
        }

        private void LoadDashboard()
        {
            pnlContent.Controls.Clear();
            Label lblStats = new Label
            {
                Text = "Dashboard Statistics (Mock Data):\n\nTotal Users: 10\nTotal Books: 50\nTotal Borrow Requests: 5",
                AutoSize = true,
                Location = new Point(20, 20)
            };
            pnlContent.Controls.Add(lblStats);
        }

        private void LoadTableView(string dataType)
        {
            pnlContent.Controls.Clear();

            // Create a DataTable with some mock data
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            // Populate with some mock rows
            for (int i = 1; i <= 5; i++)
            {
                dt.Rows.Add(i, $"{dataType} {i}");
            }

            DataGridView dgv = new DataGridView
            {
                DataSource = dt,
                Dock = DockStyle.Top,
                Height = 200,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Add control buttons column
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Actions";
            btnColumn.Text = "Edit/Delete";
            btnColumn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btnColumn);

            pnlContent.Controls.Add(dgv);

            // Add button for adding new data
            Button btnAdd = new Button
            {
                Text = "Add",
                Location = new Point(20, dgv.Bottom + 10)
            };
            btnAdd.Click += (s, e) =>
            {
                MessageBox.Show($"Add new {dataType} clicked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            pnlContent.Controls.Add(btnAdd);
        }
    }
}
