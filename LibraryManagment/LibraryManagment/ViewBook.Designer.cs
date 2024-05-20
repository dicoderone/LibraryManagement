namespace LibraryManagment
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtBookName = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtPDate = new TextBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtBookQuantity = new TextBox();
            txtBookPrice = new TextBox();
            txtPubliaction = new TextBox();
            txtAuthorName = new TextBox();
            txtBName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(18, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1255, 222);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(680, 97);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(409, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(361, 253);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookName.Location = new Point(511, 253);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(304, 30);
            txtBookName.TabIndex = 2;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(825, 252);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 33);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 294);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1255, 337);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(txtPDate);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtBookQuantity);
            panel2.Controls.Add(txtBookPrice);
            panel2.Controls.Add(txtPubliaction);
            panel2.Controls.Add(txtAuthorName);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(19, 650);
            panel2.Name = "panel2";
            panel2.Size = new Size(1255, 372);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // txtPDate
            // 
            txtPDate.Location = new Point(877, 53);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(267, 30);
            txtPDate.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(1040, 297);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 41);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(910, 297);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 41);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(769, 297);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 41);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Location = new Point(877, 223);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(267, 30);
            txtBookQuantity.TabIndex = 10;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Location = new Point(877, 132);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(267, 30);
            txtBookPrice.TabIndex = 9;
            // 
            // txtPubliaction
            // 
            txtPubliaction.Location = new Point(284, 230);
            txtPubliaction.Name = "txtPubliaction";
            txtPubliaction.Size = new Size(267, 30);
            txtPubliaction.TabIndex = 8;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(284, 135);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(267, 30);
            txtAuthorName.TabIndex = 7;
            // 
            // txtBName
            // 
            txtBName.Location = new Point(284, 55);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(267, 30);
            txtBName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(661, 225);
            label8.Name = "label8";
            label8.Size = new Size(148, 28);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(661, 134);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(661, 55);
            label6.Name = "label6";
            label6.Size = new Size(202, 28);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(68, 232);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 2;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(68, 137);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 1;
            label4.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 57);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1298, 662);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "ViewBook";
            Text = " ";
            Load += ViewBook_Load;
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
        private Label label1;
        private Label label2;
        private TextBox txtBookName;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private TextBox txtBookQuantity;
        private TextBox txtBookPrice;
        private TextBox txtPubliaction;
        private TextBox txtAuthorName;
        private TextBox txtBName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtPDate;
    }
}