using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class Books : Form
    {
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public Books()
        {
            InitializeComponent();
            SetActiveButton(btnQuanLySach);
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

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                var f = new SignInForm();
                f.Show();
            }
        }

        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
