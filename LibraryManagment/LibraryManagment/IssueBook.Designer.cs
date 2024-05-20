namespace LibraryManagment
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnrollement = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            comboBoxBooks = new ComboBox();
            btnIssueBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtEmal = new TextBox();
            txtContact = new TextBox();
            txtSemestr = new TextBox();
            txtDepartment = new TextBox();
            txtName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 183);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(508, 76);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 1;
            label1.Text = "Issue Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearchStudent);
            panel2.Controls.Add(txtEnrollement);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 510);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(206, 401);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 42);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button3_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(60, 401);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 42);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchStudent.Location = new Point(74, 275);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(222, 69);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnrollement
            // 
            txtEnrollement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtEnrollement.Location = new Point(44, 220);
            txtEnrollement.Name = "txtEnrollement";
            txtEnrollement.Size = new Size(294, 31);
            txtEnrollement.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 181);
            label2.Name = "label2";
            label2.Size = new Size(245, 31);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollement No";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(115, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(comboBoxBooks);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(txtEmal);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtSemestr);
            panel3.Controls.Add(txtDepartment);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(407, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(621, 511);
            panel3.TabIndex = 2;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBooks.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(269, 304);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(250, 33);
            comboBoxBooks.TabIndex = 16;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBook.Location = new Point(497, 418);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(94, 45);
            btnIssueBook.TabIndex = 15;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(269, 371);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // txtEmal
            // 
            txtEmal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmal.Location = new Point(269, 249);
            txtEmal.Name = "txtEmal";
            txtEmal.Size = new Size(250, 27);
            txtEmal.TabIndex = 12;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Location = new Point(269, 197);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(250, 27);
            txtContact.TabIndex = 11;
            // 
            // txtSemestr
            // 
            txtSemestr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSemestr.Location = new Point(269, 147);
            txtSemestr.Name = "txtSemestr";
            txtSemestr.Size = new Size(250, 27);
            txtSemestr.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDepartment.Location = new Point(269, 88);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(250, 27);
            txtDepartment.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(269, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(68, 369);
            label10.Name = "label10";
            label10.Size = new Size(150, 28);
            label10.TabIndex = 7;
            label10.Text = "Book Issue Date";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(121, 477);
            label9.Name = "label9";
            label9.Size = new Size(500, 31);
            label9.TabIndex = 6;
            label9.Text = "Maximum 3 Books Can be Issues to 1 Student";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(68, 304);
            label8.Name = "label8";
            label8.Size = new Size(114, 28);
            label8.TabIndex = 5;
            label8.Text = "Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(68, 248);
            label7.Name = "label7";
            label7.Size = new Size(132, 28);
            label7.TabIndex = 4;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(68, 197);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 3;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 147);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 2;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 99);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 1;
            label4.Text = "Department";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 44);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1040, 726);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBook";
            Text = "IssueBook";
            Load += IssueBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox txtEnrollement;
        private Button btnSearchStudent;
        private Button btnExit;
        private Button btnRefresh;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEmal;
        private TextBox txtContact;
        private TextBox txtSemestr;
        private TextBox txtDepartment;
        private TextBox txtName;
        private Button btnIssueBook;
        private ComboBox comboBoxBooks;
    }
}