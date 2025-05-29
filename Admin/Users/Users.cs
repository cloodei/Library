using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class Users : Form
    {
        // Colors
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public Users()
        {
            InitializeComponent();
            SetActiveButton(btnQuanLyNguoiDung);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnYeuCauMuonSach);
            var yc = new BorrowRequests();
            yc.Show();
            this.Hide();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLySach);
            var bks = new Books();
            bks.Show();
            this.Hide();
        }
    }
}
