using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class BorrowRequests : Form
    {
        // Colors
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public BorrowRequests()
        {
            InitializeComponent();
            SetActiveButton(btnYeuCauMuonSach);
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
            if (activeButton != null)
            {
                activeButton.BackColor = PrimaryColor;
            }
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLySach);
            var userBooksForm = new Books();
            userBooksForm.Show();
            this.Close();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLyNguoiDung);
            var u = new Users();
            u.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvBooks.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Khi ấn button chấp nhận, các hàng được chọn trong dgvBooks sẽ nhảy vào dgvAccept trong tab Đã chấp nhận
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Khi ấn button huỷ yêu cầu, các hàng được chọn trong dgvBooks sẽ nhảy vào dgvAccept trong tab Đã huỷ
        }

        private void dgvBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool da_chon = dgvBooks.CurrentRow.Selected;
            if (da_chon)
                dgvBooks.CurrentRow.Selected = false;
            else
                dgvBooks.CurrentRow.Selected = true;
        }
    }
}
