namespace Library
{
    partial class Books
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.Button btnHome;
        internal System.Windows.Forms.Button btnQuanLySach;
        internal System.Windows.Forms.Button btnQuanLyNguoiDung;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            btnHome = new Button();
            btnQuanLySach = new Button();
            btnQuanLyNguoiDung = new Button();
            panel1 = new Panel();
            btnSignOut = new Button();
            lblTitle = new Label();
            btnYeuCauMuonSach = new Button();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            panelContentHeader = new Panel();
            lblContentHeader = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            panelContentHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(41, 128, 185);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(3, 169);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(194, 46);
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
            btnQuanLySach.Location = new Point(3, 220);
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Size = new Size(194, 46);
            btnQuanLySach.TabIndex = 4;
            btnQuanLySach.Text = "Quản lý sách";
            btnQuanLySach.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyNguoiDung
            // 
            btnQuanLyNguoiDung.BackColor = Color.FromArgb(41, 128, 185);
            btnQuanLyNguoiDung.FlatAppearance.BorderSize = 0;
            btnQuanLyNguoiDung.FlatStyle = FlatStyle.Flat;
            btnQuanLyNguoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuanLyNguoiDung.ForeColor = Color.White;
            btnQuanLyNguoiDung.Location = new Point(4, 324);
            btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            btnQuanLyNguoiDung.Size = new Size(194, 46);
            btnQuanLyNguoiDung.TabIndex = 5;
            btnQuanLyNguoiDung.Text = "Quản lý người dùng";
            btnQuanLyNguoiDung.UseVisualStyleBackColor = false;
            btnQuanLyNguoiDung.Click += btnQuanLyNguoiDung_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnYeuCauMuonSach);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnQuanLySach);
            panel1.Controls.Add(btnQuanLyNguoiDung);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 561);
            panel1.TabIndex = 4;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.FromArgb(41, 128, 185);
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.Location = new Point(3, 503);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(194, 46);
            btnSignOut.TabIndex = 9;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(50, 107);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 37);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Admin";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYeuCauMuonSach
            // 
            btnYeuCauMuonSach.BackColor = Color.FromArgb(41, 128, 185);
            btnYeuCauMuonSach.FlatAppearance.BorderSize = 0;
            btnYeuCauMuonSach.FlatStyle = FlatStyle.Flat;
            btnYeuCauMuonSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnYeuCauMuonSach.ForeColor = Color.White;
            btnYeuCauMuonSach.Location = new Point(3, 272);
            btnYeuCauMuonSach.Name = "btnYeuCauMuonSach";
            btnYeuCauMuonSach.Size = new Size(194, 46);
            btnYeuCauMuonSach.TabIndex = 7;
            btnYeuCauMuonSach.Text = "Quản lý yêu cầu mượn sách";
            btnYeuCauMuonSach.UseVisualStyleBackColor = false;
            btnYeuCauMuonSach.Click += btnYeuCauMuonSach_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelContentHeader);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(808, 561);
            panelContent.TabIndex = 7;
            // 
            // panelContentHeader
            // 
            panelContentHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelContentHeader.Controls.Add(lblContentHeader);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 0);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(808, 60);
            panelContentHeader.TabIndex = 0;
            // 
            // lblContentHeader
            // 
            lblContentHeader.AutoSize = true;
            lblContentHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblContentHeader.ForeColor = Color.White;
            lblContentHeader.Location = new Point(15, 15);
            lblContentHeader.Name = "lblContentHeader";
            lblContentHeader.Size = new Size(144, 30);
            lblContentHeader.TabIndex = 0;
            lblContentHeader.Text = "Quản lý sách";
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 561);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 548);
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liberate";
            FormClosed += Books_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            ResumeLayout(false);
        }
        internal Button btnYeuCauMuonSach;
        private Label lblTitle;
        internal Button btnSignOut;
    }
}
