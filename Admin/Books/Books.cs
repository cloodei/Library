using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class Books : Form
    {
        // Colors
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public Books()
        {
            InitializeComponent();
            SetActiveButton(btnQuanLySach);
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

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLyNguoiDung);
            var u = new Users();
            u.Show();
            this.Close();
        }

        private void btnYeuCauMuonSach_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnYeuCauMuonSach);
            var bs = new BorrowRequests();
            bs.Show();
            this.Close();
        }
    }
}
