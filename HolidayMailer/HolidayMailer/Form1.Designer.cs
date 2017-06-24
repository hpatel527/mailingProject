namespace HolidayMailer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridDatabase = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.radioPrevious = new System.Windows.Forms.RadioButton();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.comboEmail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.txtAttach = new System.Windows.Forms.TextBox();
            this.lblAttach = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridDatabase
            // 
            this.dataGridDatabase.AllowUserToAddRows = false;
            this.dataGridDatabase.AllowUserToDeleteRows = false;
            this.dataGridDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.PreviousEmail});
            this.dataGridDatabase.Location = new System.Drawing.Point(0, 169);
            this.dataGridDatabase.Name = "dataGridDatabase";
            this.dataGridDatabase.ReadOnly = true;
            this.dataGridDatabase.Size = new System.Drawing.Size(451, 303);
            this.dataGridDatabase.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PreviousEmail
            // 
            this.PreviousEmail.HeaderText = "Sent Previous Email";
            this.PreviousEmail.Name = "PreviousEmail";
            this.PreviousEmail.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(377, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(0, 38);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(0, 64);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(0, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // radioPrevious
            // 
            this.radioPrevious.AutoSize = true;
            this.radioPrevious.Location = new System.Drawing.Point(0, 116);
            this.radioPrevious.Name = "radioPrevious";
            this.radioPrevious.Size = new System.Drawing.Size(140, 17);
            this.radioPrevious.TabIndex = 6;
            this.radioPrevious.TabStop = true;
            this.radioPrevious.Text = "Sent email previous year";
            this.radioPrevious.UseVisualStyleBackColor = true;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(106, 41);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 7;
            this.lblFName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(106, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(107, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email Address";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add to the database";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(169, 43);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(167, 13);
            this.lblSort.TabIndex = 12;
            this.lblSort.Text = "Sort By the Letter of (blank == all):";
            // 
            // comboEmail
            // 
            this.comboEmail.FormattingEnabled = true;
            this.comboEmail.Items.AddRange(new object[] {
            "All People",
            "People that sent previous email"});
            this.comboEmail.Location = new System.Drawing.Point(249, 78);
            this.comboEmail.Name = "comboEmail";
            this.comboEmail.Size = new System.Drawing.Size(121, 21);
            this.comboEmail.TabIndex = 13;
            this.comboEmail.SelectedIndexChanged += new System.EventHandler(this.comboEmail_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Send email";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(377, 75);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(342, 40);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(28, 20);
            this.txtLetter.TabIndex = 16;
            // 
            // txtAttach
            // 
            this.txtAttach.Location = new System.Drawing.Point(249, 124);
            this.txtAttach.Name = "txtAttach";
            this.txtAttach.Size = new System.Drawing.Size(190, 20);
            this.txtAttach.TabIndex = 17;
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.Location = new System.Drawing.Point(246, 108);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(171, 13);
            this.lblAttach.TabIndex = 18;
            this.lblAttach.Text = "File path for attach. (no quotations)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 470);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.txtAttach);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEmail);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.radioPrevious);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridDatabase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HolidayMailer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridDatabase;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton radioPrevious;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox comboEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousEmail;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.TextBox txtAttach;
        private System.Windows.Forms.Label lblAttach;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

