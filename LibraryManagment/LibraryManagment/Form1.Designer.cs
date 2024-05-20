


namespace LibraryManagment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            btnLogin = new Button();
            button2 = new Button();
            pictureBoxTelegram = new PictureBox();
            pictureBoxInstagram = new PictureBox();
            btn_Close = new Button();
            pictureBoxFacebook = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTelegram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 65);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(164, 186);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Black;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.Window;
            txtUsername.Location = new Point(164, 346);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(322, 27);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            txtUsername.MouseClick += txtUsername_MouseClick;
            txtUsername.MouseEnter += txtUsername_MouseEnter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(164, 440);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(322, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.MouseClick += txtPassword_MouseClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(90, 338);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(90, 424);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(166, 372);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 1);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 1);
            panel3.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(166, 473);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 1);
            panel1.TabIndex = 10;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(90, 546);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(394, 64);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(90, 631);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(394, 64);
            button2.TabIndex = 12;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBoxTelegram
            // 
            pictureBoxTelegram.Image = (Image)resources.GetObject("pictureBoxTelegram.Image");
            pictureBoxTelegram.Location = new Point(90, 721);
            pictureBoxTelegram.Margin = new Padding(3, 4, 3, 4);
            pictureBoxTelegram.Name = "pictureBoxTelegram";
            pictureBoxTelegram.Size = new Size(70, 52);
            pictureBoxTelegram.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTelegram.TabIndex = 13;
            pictureBoxTelegram.TabStop = false;
            // 
            // pictureBoxInstagram
            // 
            pictureBoxInstagram.Image = (Image)resources.GetObject("pictureBoxInstagram.Image");
            pictureBoxInstagram.Location = new Point(250, 721);
            pictureBoxInstagram.Margin = new Padding(3, 4, 3, 4);
            pictureBoxInstagram.Name = "pictureBoxInstagram";
            pictureBoxInstagram.Size = new Size(70, 52);
            pictureBoxInstagram.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInstagram.TabIndex = 14;
            pictureBoxInstagram.TabStop = false;
            // 
            // btn_Close
            // 
            btn_Close.FlatStyle = FlatStyle.Popup;
            btn_Close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.FromArgb(192, 0, 0);
            btn_Close.Location = new Point(573, 2);
            btn_Close.Margin = new Padding(3, 4, 3, 4);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(64, 38);
            btn_Close.TabIndex = 16;
            btn_Close.Text = "X";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += button3_Click;
            // 
            // pictureBoxFacebook
            // 
            pictureBoxFacebook.Image = (Image)resources.GetObject("pictureBoxFacebook.Image");
            pictureBoxFacebook.Location = new Point(416, 721);
            pictureBoxFacebook.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFacebook.Name = "pictureBoxFacebook";
            pictureBoxFacebook.Size = new Size(70, 52);
            pictureBoxFacebook.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFacebook.TabIndex = 17;
            pictureBoxFacebook.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(640, 826);
            Controls.Add(pictureBoxFacebook);
            Controls.Add(btn_Close);
            Controls.Add(pictureBoxInstagram);
            Controls.Add(pictureBoxTelegram);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(35, 36, 50);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "77";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTelegram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFacebook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Button btnLogin;
        private Button button2;
        private PictureBox pictureBoxTelegram;
        private PictureBox pictureBoxInstagram;
        private Button btn_Close;
        private PictureBox pictureBoxFacebook;
    }
}
