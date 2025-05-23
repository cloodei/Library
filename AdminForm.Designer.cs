namespace Library
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageBorrowRequests;

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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            pnlSidebar = new Panel();
            btnManageBorrowRequests = new Button();
            btnManageBooks = new Button();
            btnManageUsers = new Button();
            btnDashboard = new Button();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.ControlLight;
            pnlSidebar.Controls.Add(btnManageBorrowRequests);
            pnlSidebar.Controls.Add(btnManageBooks);
            pnlSidebar.Controls.Add(btnManageUsers);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(150, 450);
            pnlSidebar.TabIndex = 2;
            // 
            // btnManageBorrowRequests
            // 
            btnManageBorrowRequests.Location = new Point(12, 140);
            btnManageBorrowRequests.Name = "btnManageBorrowRequests";
            btnManageBorrowRequests.Size = new Size(125, 30);
            btnManageBorrowRequests.TabIndex = 3;
            btnManageBorrowRequests.Text = "Manage Borrow Requests";
            btnManageBorrowRequests.UseVisualStyleBackColor = true;
            btnManageBorrowRequests.Click += btnManageBorrowRequests_Click;
            // 
            // btnManageBooks
            // 
            btnManageBooks.Location = new Point(12, 100);
            btnManageBooks.Name = "btnManageBooks";
            btnManageBooks.Size = new Size(125, 30);
            btnManageBooks.TabIndex = 2;
            btnManageBooks.Text = "Manage Books";
            btnManageBooks.UseVisualStyleBackColor = true;
            btnManageBooks.Click += btnManageBooks_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(12, 60);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(125, 30);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 20);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(125, 30);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(150, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(650, 450);
            pnlContent.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "Library Management - Admin";
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
