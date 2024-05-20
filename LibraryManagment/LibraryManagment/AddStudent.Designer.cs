namespace LibraryManagment
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSaveInfo = new Button();
            btnRefresh = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 140);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(508, 49);
            label1.Name = "label1";
            label1.Size = new Size(160, 35);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 425);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSaveInfo);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(358, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 425);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(520, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.FlatStyle = FlatStyle.Popup;
            btnSaveInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveInfo.Location = new Point(395, 372);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(94, 40);
            btnSaveInfo.TabIndex = 13;
            btnSaveInfo.Text = "Save Info";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(269, 373);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 39);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(277, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(277, 265);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(312, 27);
            txtContact.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(277, 204);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(312, 27);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(277, 143);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(312, 27);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(277, 86);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(312, 27);
            txtEnrollment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(277, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 27);
            txtName.TabIndex = 6;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(52, 316);
            label7.Name = "label7";
            label7.Size = new Size(145, 28);
            label7.TabIndex = 5;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(52, 268);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 4;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(52, 210);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 3;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 149);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 89);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 28);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1009, 595);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            Load += AddStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private Button btnExit;
        private Button btnSaveInfo;
        private Button btnRefresh;
    }
}