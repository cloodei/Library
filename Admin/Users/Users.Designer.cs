namespace Library
{
    partial class Users
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.DataGridView dgvBooks;
        internal System.Windows.Forms.Button btnHome;
        internal System.Windows.Forms.Button btnQuanLySach;
        internal System.Windows.Forms.Button btnQuanLyNguoiDung;
        private System.Windows.Forms.Label lblTitle;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelContent;
        private Panel panelContentHeader;
        private Label lblContentHeader;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            dgvBooks = new DataGridView();
            btnHome = new Button();
            btnQuanLySach = new Button();
            btnQuanLyNguoiDung = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            btnYeuCauMuonSach = new Button();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            panelContentHeader = new Panel();
            lblContentHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            panelContentHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle4.Padding = new Padding(15, 5, 15, 5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBooks.ColumnHeadersHeight = 29;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle5;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(0, 80);
            dgvBooks.Margin = new Padding(3, 4, 3, 4);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle6.Padding = new Padding(15, 5, 15, 5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(224, 242, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(923, 668);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellMouseEnter += dgvBooks_CellMouseEnter;
            dgvBooks.CellMouseLeave += dgvBooks_CellMouseLeave;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(41, 128, 185);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(3, 225);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(222, 61);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnQuanLySach
            // 
            btnQuanLySach.BackColor = Color.FromArgb(41, 128, 185);
            btnQuanLySach.FlatAppearance.BorderSize = 0;
            btnQuanLySach.FlatStyle = FlatStyle.Flat;
            btnQuanLySach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuanLySach.ForeColor = Color.White;
            btnQuanLySach.Location = new Point(3, 294);
            btnQuanLySach.Margin = new Padding(3, 4, 3, 4);
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Size = new Size(222, 61);
            btnQuanLySach.TabIndex = 4;
            btnQuanLySach.Text = "Quản lý sách";
            btnQuanLySach.UseVisualStyleBackColor = false;
            btnQuanLySach.Click += btnQuanLySach_Click;
            // 
            // btnQuanLyNguoiDung
            // 
            btnQuanLyNguoiDung.BackColor = Color.FromArgb(41, 128, 185);
            btnQuanLyNguoiDung.FlatAppearance.BorderSize = 0;
            btnQuanLyNguoiDung.FlatStyle = FlatStyle.Flat;
            btnQuanLyNguoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuanLyNguoiDung.ForeColor = Color.White;
            btnQuanLyNguoiDung.Location = new Point(4, 432);
            btnQuanLyNguoiDung.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            btnQuanLyNguoiDung.Size = new Size(222, 61);
            btnQuanLyNguoiDung.TabIndex = 5;
            btnQuanLyNguoiDung.Text = "Quản lý người dùng";
            btnQuanLyNguoiDung.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(42, 143);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(164, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thư Viện";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(btnYeuCauMuonSach);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnQuanLySach);
            panel1.Controls.Add(btnQuanLyNguoiDung);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 748);
            panel1.TabIndex = 4;
            // 
            // btnYeuCauMuonSach
            // 
            btnYeuCauMuonSach.BackColor = Color.FromArgb(41, 128, 185);
            btnYeuCauMuonSach.FlatAppearance.BorderSize = 0;
            btnYeuCauMuonSach.FlatStyle = FlatStyle.Flat;
            btnYeuCauMuonSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnYeuCauMuonSach.ForeColor = Color.White;
            btnYeuCauMuonSach.Location = new Point(3, 363);
            btnYeuCauMuonSach.Margin = new Padding(3, 4, 3, 4);
            btnYeuCauMuonSach.Name = "btnYeuCauMuonSach";
            btnYeuCauMuonSach.Size = new Size(222, 61);
            btnYeuCauMuonSach.TabIndex = 7;
            btnYeuCauMuonSach.Text = "Quản lý yêu cầu mượn sách";
            btnYeuCauMuonSach.UseVisualStyleBackColor = false;
            btnYeuCauMuonSach.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dgvBooks);
            panelContent.Controls.Add(panelContentHeader);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(229, 0);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(923, 748);
            panelContent.TabIndex = 7;
            // 
            // panelContentHeader
            // 
            panelContentHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelContentHeader.Controls.Add(lblContentHeader);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 0);
            panelContentHeader.Margin = new Padding(3, 4, 3, 4);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(923, 80);
            panelContentHeader.TabIndex = 0;
            // 
            // lblContentHeader
            // 
            lblContentHeader.AutoSize = true;
            lblContentHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblContentHeader.ForeColor = Color.White;
            lblContentHeader.Location = new Point(17, 20);
            lblContentHeader.Name = "lblContentHeader";
            lblContentHeader.Size = new Size(270, 37);
            lblContentHeader.TabIndex = 0;
            lblContentHeader.Text = "Quản lý người dùng";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 748);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1168, 784);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liberate";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            ResumeLayout(false);
        }
        internal Button btnYeuCauMuonSach;
    }
}
