namespace Library
{
    partial class BorrowRequests
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.DataGridView dgvBooks;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowRequests));
            dgvBooks = new DataGridView();
            btnHome = new Button();
            btnQuanLySach = new Button();
            btnQuanLyNguoiDung = new Button();
            panel1 = new Panel();
            btnSignOut = new Button();
            lblTitle = new Label();
            btnYeuCauMuonSach = new Button();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            tabControl1 = new TabControl();
            tab1 = new TabPage();
            tabPage2 = new TabPage();
            dgvAccept = new DataGridView();
            tabPage1 = new TabPage();
            dgvRefuse = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelContentHeader = new Panel();
            lblContentHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccept).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRefuse).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelContentHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Padding = new Padding(15, 5, 15, 5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(3, 2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.Padding = new Padding(15, 5, 15, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 242, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(794, 415);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellMouseClick += dgvBooks_CellMouseClick;
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
            btnQuanLySach.Click += btnQuanLySach_Click;
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
            panel1.Size = new Size(200, 553);
            panel1.TabIndex = 4;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.FromArgb(41, 128, 185);
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.Location = new Point(3, 495);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(194, 46);
            btnSignOut.TabIndex = 10;
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
            panelContent.Controls.Add(tabControl1);
            panelContent.Controls.Add(panel2);
            panelContent.Controls.Add(panelContentHeader);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(808, 553);
            panelContent.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 60);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 447);
            tabControl1.TabIndex = 4;
            // 
            // tab1
            // 
            tab1.Controls.Add(dgvBooks);
            tab1.Location = new Point(4, 24);
            tab1.Margin = new Padding(3, 2, 3, 2);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3, 2, 3, 2);
            tab1.Size = new Size(800, 419);
            tab1.TabIndex = 0;
            tab1.Text = "Các yêu cầu";
            tab1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvAccept);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(800, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Đã chấp nhận";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAccept
            // 
            dgvAccept.AllowUserToAddRows = false;
            dgvAccept.AllowUserToDeleteRows = false;
            dgvAccept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccept.Dock = DockStyle.Fill;
            dgvAccept.Location = new Point(3, 2);
            dgvAccept.Margin = new Padding(3, 2, 3, 2);
            dgvAccept.Name = "dgvAccept";
            dgvAccept.ReadOnly = true;
            dgvAccept.RowHeadersWidth = 51;
            dgvAccept.Size = new Size(794, 415);
            dgvAccept.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvRefuse);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(800, 419);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Đã huỷ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRefuse
            // 
            dgvRefuse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRefuse.Dock = DockStyle.Fill;
            dgvRefuse.Location = new Point(0, 0);
            dgvRefuse.Margin = new Padding(3, 2, 3, 2);
            dgvRefuse.Name = "dgvRefuse";
            dgvRefuse.RowHeadersWidth = 51;
            dgvRefuse.Size = new Size(800, 419);
            dgvRefuse.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 507);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 46);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(338, 8);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(470, 36);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(315, 2);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(152, 32);
            button3.TabIndex = 2;
            button3.Text = "Huỷ yêu cầu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(159, 2);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(150, 32);
            button2.TabIndex = 1;
            button2.Text = "Chấp nhận";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 32);
            button1.TabIndex = 0;
            button1.Text = "Chọn tất cả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            lblContentHeader.Size = new Size(159, 30);
            lblContentHeader.TabIndex = 0;
            lblContentHeader.Text = "Yêu cầu mượn";
            // 
            // BorrowRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 553);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 548);
            Name = "BorrowRequests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liberate";
            FormClosed += BorrowRequests_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccept).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRefuse).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            ResumeLayout(false);
        }
        internal Button btnYeuCauMuonSach;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tab1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private DataGridView dgvAccept;
        private DataGridView dgvRefuse;
        private Label lblTitle;
        internal Button btnSignOut;
    }
}
