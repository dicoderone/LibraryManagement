namespace LibraryManagment
{
    partial class ViewStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInfo));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchEnrollment = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 190);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(677, 100);
            label2.Name = "label2";
            label2.Size = new Size(129, 41);
            label2.TabIndex = 2;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(686, 64);
            label1.Name = "label1";
            label1.Size = new Size(87, 41);
            label1.TabIndex = 1;
            label1.Text = "View";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(438, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(306, 214);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchEnrollment.Location = new Point(474, 214);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(232, 29);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(746, 214);
            button1.Name = "button1";
            button1.Size = new Size(108, 34);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1281, 362);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 368);
            panel2.TabIndex = 5;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1080, 283);
            button4.Name = "button4";
            button4.Size = new Size(101, 35);
            button4.TabIndex = 14;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(945, 283);
            button3.Name = "button3";
            button3.Size = new Size(101, 35);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(793, 283);
            button2.Name = "button2";
            button2.Size = new Size(101, 35);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(873, 188);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(275, 29);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(873, 114);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(275, 29);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(873, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(275, 29);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(263, 188);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 29);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(263, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 29);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(263, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 29);
            textBox2.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(678, 183);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 5;
            label9.Text = "Student Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(677, 109);
            label8.Name = "label8";
            label8.Size = new Size(165, 28);
            label8.TabIndex = 4;
            label8.Text = "Student Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(678, 42);
            label7.Name = "label7";
            label7.Size = new Size(183, 28);
            label7.TabIndex = 3;
            label7.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(94, 183);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 2;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(93, 111);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 1;
            label5.Text = "Enrollment No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 42);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 0;
            label4.Text = "Student Name";
            // 
            // ViewStudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1324, 654);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ViewStudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInfo";
            Load += ViewStudentInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSearchEnrollment;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}